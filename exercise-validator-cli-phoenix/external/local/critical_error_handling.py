import sys
from external.local.logger import Logger
from external.local import user_presenter


def log_uncaught_exceptions(type, value, traceback):
    logger = Logger.get_logger()
    text_dict = {"type": type,
                 "value": value,
                 "traceback": traceback}
    logger.critical("Unhandled exception: %s", text_dict)
    user_presenter.fatal_error()


def set_uncaught_ex_handling():
    sys.excepthook = log_uncaught_exceptions
