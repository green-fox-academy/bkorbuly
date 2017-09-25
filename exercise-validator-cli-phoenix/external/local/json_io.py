import json


def save_json_content(path, content):
    with open(path, "w") as output:
        output.write(json.dumps(content, indent=2, sort_keys=True))


def get_json_content(path):
    with open(path, "r") as input:
        return json.loads(input.read())
