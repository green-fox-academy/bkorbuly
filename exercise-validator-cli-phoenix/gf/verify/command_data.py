from enum import Enum


class CommandType(Enum):
    COMPILE = 0
    RUN = 1
    DELETE = 2


class CommandData:

    def __init__(self, command=None, type=CommandType.RUN, input=None,
                 regex=None):
        self.command = command
        self.type = type
        self.regex = regex
        self.input = input
