"""gf.

Usage:
  gf config [<logfile>]
  gf start <github_link> [<logfile>]
  gf verify <filename> [<logfile>]
  gf -h | --help
  gf rate <exercise-path>
  gf debug

Options:
  help    show this screen.
  config  set githubcredentials.
  verify  check task.
  start   download WS files.
  rate    rate exercise between 1-5.
  debug   show debug file

"""
from docopt import docopt


def get_command_argument():
    return arguments[0]


def get_link():
    return arguments[1]


def get_filename():
    return get_link()


def convert_docopt_dictionary_to_usual_arg_list(args):
    command_arguments = []
    command = None
    for key, value in args.items():
        if not (value is None or value is False):
            if isinstance(value, bool):
                command = key
            else:
                command_arguments.append(value)
    command_arguments.sort(reverse=True)
    return [command] + command_arguments


arguments = convert_docopt_dictionary_to_usual_arg_list(
    docopt(__doc__, options_first=True))
