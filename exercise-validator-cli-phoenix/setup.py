from setuptools import setup

setup(
    name='gf-ev-cli',
    packages=['gf', 'external', 'gf.config', 'gf.rate',
              'gf.verify', 'gf.start', 'external.web', 'external.local'],
    entry_points={
        'console_scripts': ['gf = gf.app_starter:main']
    },
    version='2.3.0',
    description='',
    long_description='',
    author='GFA',
    author_email='',
    url='https://github.com/greenfox-academy/exercise-validator-cli/',
    install_requires=[
        'PyGithub',
        'docopt',
        'python-json-logger',
        'requests'
    ],
)
