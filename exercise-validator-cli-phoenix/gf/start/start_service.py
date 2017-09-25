from external.local import json_handler, user_presenter, environment_checks, \
    env_test_setter
from external.web import github, url_handler
from gf.start import ws_datas_collector
from gf.settings import APP_OUTDATED_COMMAND, APP_NAME
from github import GithubException
from gf.verify import subprocess_adapter, command_data


def main(url):
    prepare_to_start(url)
    workshop_data = workshop_collect(url)
    finish(workshop_data)


def prepare_to_start(url):
    check_app_version()
    check_environments(url)
    user_presenter.start_communicating()


def check_app_version():
    outdated_apps_data = subprocess_adapter.run(
        create_command_data_to_version_check())
    check_if_outdated(outdated_apps_data)


def check_if_outdated(app_data):
    if APP_NAME in str(app_data.stdout):
        user_presenter.need_to_update()


def workshop_collect(url):
    try:
        workshop_data = ws_datas_collector.collect_workshop_data(url)
        test_paths = collect_workshop_contents(workshop_data)
        workshop_data["exercises"] = test_paths
    except (IndexError, GithubException, UnboundLocalError):
        user_presenter.ws_not_found()
    return workshop_data


def create_command_data_to_version_check():
    return command_data.CommandData(APP_OUTDATED_COMMAND,
                                    command_data.CommandType.RUN)


def finish(workshop_data):
    json_handler.save_json_content(".gf.json", workshop_data)
    user_presenter.exercise_collect_finished()
    github.generate_issues(get_ex_names(workshop_data))
    user_presenter.issue_generation_finished()


def get_ex_names(workshop_data):
    return list(workshop_data["exercises"].keys())


def check_environments(url):
    language = url_handler.get_lang_from_url(url)
    json_handler.check_gfjson()
    environment_checks.check_environment(language)
    env_test_setter.set_test_environment(language)


def collect_workshop_contents(workshop_data):
    return github.get_contents(workshop_data)
