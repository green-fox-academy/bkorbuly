#!/bin/bash
pip install -r requirements.txt
cp ./.setup/pre-commit ./.git/hooks
cp ./.setup/pre-push ./.git/hooks
echo "success"