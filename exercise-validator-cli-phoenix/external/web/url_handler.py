def get_ws_from_url(url):
    splitted = url.split("/master/")[1].split("/")
    del splitted[-1]
    return "/".join(splitted)


def get_lang_from_url(url):
    return url.split("/")[-1].split(".")[0]


def get_filename_from_url(url):
    return url.split("/")[-1]


def get_repo_from_url(url):
    return url.split("github.com/greenfox-academy/")[1].split("/")[0]


def transform_to_test_path(url):
    splitted = url.split("/")
    splitted.pop(-1)
    splitted.append("tests")
    return "/".join(splitted)
