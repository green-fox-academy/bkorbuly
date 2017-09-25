from external.local import user_presenter
from gf.config import config_service
from gf.verify import verify_service
from gf.start import start_service
from gf.rate import rate_service
from gf.docopt_adapter import get_filename, get_link, get_command_argument


def run():
    try:
        task_check(get_command_argument())()
    except KeyboardInterrupt:
        user_presenter.keyboard_interrupted()


def task_check(task_name):
    return {
        "config": config_start,
        "verify": verify_start,
        "start": start,
        "rate": rate_start,
        "debug": show_debug
    }[task_name]


def show_debug():
    user_presenter.show_debug()


def help_message():
    user_presenter.help_message()


def config_start():
    config_service.start()


def verify_start():
    verify_service.start(get_link())


def start():
    start_service.main(get_filename())


def rate_start():
    rate_service.start(get_filename())
