from external.local import user_presenter
from external.local.command_runner import run_single_command
from gf.verify.command_data import CommandData
from gf.settings import C_COMPILER, JAVA_COMPILER, JS_SERVER, JS_SERVER_MODULES, JS_TESTER, PY_RUN, CS_COMPILER  # nopep8
import os


def get_command(language):
    try:
        return {
                "javascript": JS_SERVER + " --version",
                "python": PY_RUN + " --version",
                "java": JAVA_COMPILER + " -version",
                "c": C_COMPILER + " --version",
                "cs": CS_COMPILER
        }[language]
    except KeyError as e:
        user_presenter.wrong_language()


def check_environment(language):
    command = CommandData(get_command(language))
    try:
        returncode = run_single_command(command).returncode
        if "javascript" == language and check_tape_for_js():
            user_presenter.env_not_found(language)
    except FileNotFoundError:
        user_presenter.env_not_found(language)
    else:
        if returncode != 0:
            user_presenter.env_not_found(language)


def check_tape_for_js():
    return not os.path.exists("./" + JS_SERVER_MODULES + JS_TESTER)
