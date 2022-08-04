# Gauge C# Automation

This documentation contains the necessary guidelines to setup the
environment and start Test Automation using C\# and Gauge Framework.
Gauge is a Test Automation Framework used for Acceptance Test Automation
enabling BDT. Gauge is a Free and Open Source Framework developed by
ThoughtWorks.Inc.

## Prerequisites:

1.  VS Code

2.  .NET V6.0.7 or higher installed

[[https://dotnet.microsoft.com/en-us/download/dotnet/]{.ul}](https://dotnet.microsoft.com/en-us/download/dotnet/)

# Getting Started

Before starting your actual Gauge C\# Project, follow these instructions
to set up the environment on your PC.

1.  Install Gauge on your PC

    1.  Go to
        > [[https://github.com/getgauge/gauge/releases]{.ul}](https://github.com/getgauge/gauge/releases)

    2.  Download the suitable Gauge Installer for your PC. (Windows/Mac/ Linux)

    3.  Run the installer.

2.  Install the Gauge Extension for VS Code

    1.  Open VS Code.

    2.  Go to Extensions.

    3.  Search for "Gauge".

    4.  Install the Gauge Extension by "getgauge".

3.  Install the C\# Extension for VS Code

    1.  Open VS Code.

    2.  Go to Extensions.

    3.  Search for "C\#".

    4.  Install the C\# Extension by "Microsoft".

After the completion of above installations, your PC must be ready to
create and run Gauge Projects.

# Creating a Test Project

To start using Gauge and C\# for Test Automation, follow the
instructions below.

1.  Clone or download and extract the sample project from GitHub and open the project from VS Code.

-   url

2.  Create a .spec file in the Specs folder :

-   Right click on 'Gauge_C\#\_Automation_Framework\\specs' folder and create a new file.

-   Name the file using a preferred name with the '.spec' file extension.

> E.g.: 'preferredName.spec'

3.  Write the spec and scenarios for the test cases.

-   Writing a Specification to learn more.

4.  Create a .cs file in Implementation folder :

-   Gauge_C\#\_Automation_Framework\\Implementation

5.  Write the Step Implementation in C\# for the corresponding spec by utilising the methods and attributes in the BasePage.cs.

-   Step implementations can be written for each Step written in a Specification.

-   To write an Implementation for a Step, 'Ctrl + Click' on a Step inside a Specification file.
 This will prompt you to Create a new .cs file or to Choose an existing
 .cs file in order to start implementing the C\# code.

-   Implementation will have to be written by implementing the Page
    > Object Model and Page Factory Model.

6.  Execute the tests by running the spec.

-   Refer Run Specifications to learn more.

7.  View Generated Reports

-   Refer View Generated Reports to learn more.

#  

# Writing a Specification (spec)

A Specification is a test case for a feature that needs to be tested.
Specifications are written in a syntax that is similar to Markdown
syntax. To run a Specification, you need to write a spec and a
corresponding Implementation in C\# (or your preferred language).

## Components of a Specification

1.  **Specification Heading**

A specification must start with a spec heading and a spec should contain
only one heading. Specification heading is written in \<h1\> markdown
syntax, which can be written in two ways.

-   Starting with a Hash<br />
    ![image1](https://user-images.githubusercontent.com/88071958/182809136-ab1bfbce-61cb-4bf4-a958-62061b3f005e.png)

-   By Underlining the Spec Heading with Equal<br />
    ![image3](https://user-images.githubusercontent.com/88071958/182809584-6b526a12-f864-4eb4-a1a4-d8d38f95628e.png)


2.  **Scenario**

A scenario is a single workflow in a specification. A specification can
contain multiple scenarios but should contain at least one. A Scenario
contains Steps for the scenario flow and it can also contain Tags and
Comments.

A scenario has a heading and is written in \<h2\> markdown syntax, which
can be written in two ways.

-   Starting with Two Hash symbols.<br />
   ![image2](https://user-images.githubusercontent.com/88071958/182809519-a11652b1-b1c2-4d6f-8907-a58b8c58dfa0.png)

-   By Underlining the Scenario Heading with<br />
    ![image4](https://user-images.githubusercontent.com/88071958/182809624-4d16f89f-bb50-488b-a8fd-76a71fce1c40.png)


3.  **Step**

Steps are the executable components in a specification. Steps are
written using Unordered List Markdown Syntax with each step starting
with a star sign.<br />

![image5](https://user-images.githubusercontent.com/88071958/182809736-68e0f8a6-fb48-4b2d-b700-04ca17e3997e.png)

Steps can be written both inside and outside of a Scenario. When they
are written inside a Scenario they represent the flow of the Scenario.
When they are written outside a Scenario they are one of the following
types,

-   **Context Steps**

 Context Steps run before each Scenario. These are written under the Specification Heading.

-   **Tear Down Steps**

 Tear Down Steps run after each Scenario. These are written separately after the last Scenario. Three or more consecutive Underscores separates the Tear Down Steps from the rest.

4.  **Parameters**

Steps can be defined to take values as parameters so that they can be
reused with different values as needed. When the corresponding code
implementation is written, it must have the same number of parameters as
well.<br />

![image6](https://user-images.githubusercontent.com/88071958/182809892-cfd002a3-02c4-4eb2-9f31-74c2af9a2cfc.png)

5.  **Tags**

Tags are used to associate labels with specs or scenarios which can help
in search and filtering. Tags are written separated by commas and
started with a prefix "Tags: "<br />

![image6](https://user-images.githubusercontent.com/88071958/182809892-cfd002a3-02c4-4eb2-9f31-74c2af9a2cfc.png)


6.  **Comments**

Comments can be written in a spec wherever it is needed in plain text to
enhance understandability of the specification. Comments are not
executed and will be ignored when a Spec is run.

###  

# Run Specifications

1.  Open a created spec file.

2.  Click on the "Run Spec" option above Specification Heading to run a
    > specification.


![image8](https://user-images.githubusercontent.com/88071958/182810057-fcb449e1-de82-493e-b612-cbf32fc73f54.png)

-   "Run Spec" and "Debug Spec" options appear automatically when
    > specifications are implemented properly.

-   Feedback of running specifications can be observed in the output
    > window of VS Code.

###  

# View Generated Reports

**Method 1:**

1.  Press F1 or ctrl + shift + p to open the Editor's Command Palette.

2.  Run Command "Gauge: Show Last Run Report"
![image6](https://user-images.githubusercontent.com/88071958/182810379-d57a3eb3-9189-4543-bd4e-0c14edc2442d.png)


**Method 2:**

1.  Click the 'View Summary' Link in VS Code.

![image9](https://user-images.githubusercontent.com/88071958/182810462-63c4c0fe-62b7-4eec-995b-2d4079749968.png)
