# configuration for the json files.
WORKSHOP_DATA_FILENAME = ".gf.json"
CONFIG_FILENAME = "config.json"
FILE_ENCODING = "utf-8"
DEBUG_FILE_NAME = "gf-debug.log"

# configuration for gihub
ORGANIZATION = "greenfox-academy"
ORGANIZATION_ID = 14247612
TOKEN_REQUEST_URL = "https://token-requester.herokuapp.com/tokenpls"

# configuration for app
APP_BASE_FOLDER_NAME = ".gf"
APP_NAME = "gf-ev-cli"
APP_OUTDATED_COMMAND = "pip list --outdated"
ASSET_FILE_EXTENSIONS = ["txt", "csv"]

# configuration for spinner
SPINNING_CURSOR_SEQUENCE = "|/-\\"

# configuration for c_environment and testing
C_COMPILER = "gcc"
C_UNITTEST_HEADER = "minunit.h"
C_COMPILED_FILENAME = "test.o"

# configuration for cs_environment and testing
CS_COMPILER = "ls"

# configuration for java_environment and testing
JAVA_COMPILER = "javac"
JUNIT_FILENAME = "junit-4.12.jar"
HAMCREST_FILENAME = "hamcrest-core-1.3.jar"

# configuration for javascript_environment and testing
JS_SERVER = "node"
JS_SERVER_MODULES = "node_modules/"
JS_TESTER = "tape"

# configuration for python_environment and testing
PY_RUN = "python"
PY_TESTER = "nose2"
PY_BYTECODE_EXTENSION = "pyc"
PY_BYTECODE_FOLDER = "__pycache__"

# configuration for regex testing
REGEX_TEST_INPUT_FIELD_NAME = "ex_input"
REGEX_TEST_OUPUT_FIELD_NAME = "ex_output"

# configuration for elastic search
ELK_HOST = "search-elk-gf-ev-cli-iyzyiukmibnnzjpsgcha26qheq." \
           "eu-west-2.es.amazonaws.com"
ELK_INDEX = "/edu_monitoring"
