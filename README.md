# Weather Forecast API

A weather forecasting API powered by OpenAI's Generative AI LLM and Retrieval-Augmented Generation (RAG) for accurate and intelligent weather predictions.

![API](https://shorturl.at/3I4Za)

## Getting Started
Follow these instructions to set up and run the project on your local machine.

### Prerequisites

- [Poetry](https://python-poetry.org/docs/#installation): A tool for dependency management and packaging in Python.

### Installing poetry using CLI:
   - `Invoke-WebRequest -Uri https://install.python-poetry.org -OutFile install-poetry.py`

1. **Save poetry to path:** 
   
   - `$env:Path += ";C:\Users\<Your user name>\AppData\Roaming\Python\Scripts" `
2. **Add poetry to path:**


   - Add the Path to Environment Variables:

   Open System Properties:
   
   Press `Win + R `, type `sysdm.cpl`, and press Enter.
   Open Environment Variables:

   In the System Properties window, go to the Advanced tab.
   Click on the `Environment Variables` button.
   Edit the `PATH` Variable

   In the Environment Variables window, under the User variables or System variables section, find the Path variable.
   Select it and click Edit and Add the path.

### If it doesn't find poetry installed:

go to directory where we used command 
 - `Invoke-WebRequest -Uri https://install.python-poetry.org -OutFile install-poetry.py`

and run following command:
 - `python install-poetry.py`

### Installation

1. **Download and Extract:**
   - Download the zip file from the FTP server.
   - Extract the contents to a directory of your choice.

2. **Set Up the Environment:**
   Navigate to the project directory:
   
   `cd Weather Forecast API`
### Create and activate the virtual environment:

```
poetry install
poetry shell
```

### Running the Application

```
uvicorn ForecastAPI:app --reload
```
<span style="color:red">Author: Shivnath Tathe</span>
