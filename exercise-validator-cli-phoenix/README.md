# Exercise Validator CLI

## ⚙️ Requirements

 -  [Python 3.6.x](https://www.python.org/)
 -  [pip](https://pypi.org/)<sup>1</sup>
 -  [Node.js](https://nodejs.org/)<sup>2</sup>
 -  [Java](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)<sup>3</sup>
 -  [GCC]( https://gcc.gnu.org/install/binaries.html)<sup>4</sup>

<sup>1</sup>should come with Python  
<sup>2</sup>required to validate JavaScript exercises  
<sup>3</sup>required to validate Java exercises  
<sup>4</sup>required to validate C exercises  

## 🛠️ Installation

This application is published on the [Python Package Index](https://pypi.org/)
(aka PyPI) so it is easily installable with pip:

`pip install gf-ev-cli`

and also easily upgradeable:

`pip install gf-ev-cli --upgrade`

If you validate JavaScript exercises include `node_modules/` in your
`.gitignore` file.

## 📚 Available commands

| Command                   | Description                                  |
| ------------------------- | -------------------------------------------- |
| `gf -h` or `gf --help`    | List the available commands and their usage. |
| `gf config`               | Configure the application.                   |
| `gf start <markdown url>` | Start a daily workshop.                      |
| `gf verify <filename>`    | Verify the selected exercise.                |
| `gf rate <filename>`      | Rate the selected exercise.                  |

## 📄 Usage

After the installation you have to execute `gf config` and provide your GitHub
credentials.** It will create a GitHub token and store it under `.gf/` folder in
your home directory.  
Then you will have to initialize the day by executing
`gf start <markdown url>`. It will download the exercises for that day into the
current directory. One folder represents one day so you can only use this
command once in a folder. A *markdown url* is an url to the current workshop's
language specified markdown file.  
When you have the solution for an exercise you can verify it by the `gf verify
<filename>` command.
You can rate an exercise between 1 to 5 by the `gf rate <filename>` command.

** Windows users should execute `gf config` either in windows CMD **OR** should execute `winpty gf config`
