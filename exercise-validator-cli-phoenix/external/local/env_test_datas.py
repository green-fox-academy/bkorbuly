from gf.settings import C_UNITTEST_HEADER, HAMCREST_FILENAME, JUNIT_FILENAME


def get_test_env_datas(language):
    return {
        "javascript": [],
        "cs": [],
        "python": [],
        "java": [
            {
                "link": "https://unit-testing.000webhostapp.com"
                        "/test_files//junit-4.12.jar",
                "file_name": JUNIT_FILENAME
            },
            {
                "link": "https://unit-testing.000webhostapp.com"
                        "/test_files/hamcrest-core-1.3.jar",
                "file_name": HAMCREST_FILENAME
            }
        ],
        "c": [
            {
                "link": "https://unit-testing.000webhostapp.com"
                        "/test_files/minunit.h",
                "file_name": C_UNITTEST_HEADER
            }
        ]
    }[language]
