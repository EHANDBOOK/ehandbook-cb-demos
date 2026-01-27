# Demo: [Human-Readable Title of the Demo]

> **_INSTRUCTIONS FOR THE WRITER (delete this section):_**
>
> * **_Goal:_** _This file is the complete guide for a single, self-contained demo._
> * **_Audience:_** _Assume the reader is an engineer or technical writer who is new to EHANDBOOK Container-Build but familiar with the source technologies (e.g., Simulink, C)._
> * **_Tone:_** _Clear, direct, and encouraging. Focus on helping the user get a "quick win" and then understand how it worked._
> * **_Action:_** _Copy this template into a demo folder, rename it to `README.md`, and fill in the bracketed `[...]` sections._

**Objective:** [Write a single, clear sentence describing what this demo accomplishes. Start with "This demo shows..." or "This demo illustrates..."]

* **_Good Example:_** _This demo shows how to generate an EHANDBOOK from a simple C-code project with a custom configuration._
* **_Bad Example:_** _A demo for C-code._

---

## ✨ Features Showcased

[List the key EHANDBOOK Container-Build features or concepts this demo highlights. This helps users quickly identify if the demo is relevant to their problem.]

* **_Example List:_**
* _C-Code analysis_
* _Directory-based input structure_
* _Custom table configuration (`TableConfiguration.json`)_
* _Use of a specific configuration parameter (e.g., `globalDefines`)_

---

## 🛠️ How to Run

[Provide simple, numbered steps to build the demo. The goal is to get the user to a successful build as quickly as possible.]

1. **Prerequisites:**
    * [List any necessary software, e.g., Docker, MATLAB R2022b, TargetLink, etc.]
    * Ensure you have run the `set_tool_paths.bat` script in the repository root.

2. **Build:**
    * Open a command prompt or terminal.
    * Navigate to this directory (`[e.g., Demo_DirBased_CCode_simple]`).
    * Execute the `build.bat` script.

---

## 🔬 Explore the Output

[Tell the user what to expect after a successful build and where to find it. This confirms their success and guides their exploration.]

* **_Example:_**
* _After the build completes, navigate to the `Output/` folder._
* _Open the generated EHANDBOOK._
* _Notice that the functions from the `Input/` directory are documented and the "Global Macros" chapter is present, as defined in the configuration._

---

## ⚙️ Under the Hood

[This is the core learning section. Explain _how_ the demo works by breaking down its components. Be specific and use code snippets.]

### Directory Structure

* `Input/`: [Explain what's in here, e.g., "Contains the source C-code files to be documented."]
* `Output/`: [Explain what's in here, e.g., "The destination for the generated EHANDBOOK."]
* `[configuration.json]`: [Explain the role of the config file, e.g., "The main EHB-CB configuration file that defines the build process."]
* `build.bat`: [Explain the script's role, e.g., "A simple script that invokes the EHB-CB Docker container, mounting the necessary local directories."]

### Configuration Deep Dive

[Explain the most important settings in the configuration file(s) that make this specific demo work. Show snippets of the JSON/XML and use comments or descriptive text to clarify their purpose.]
