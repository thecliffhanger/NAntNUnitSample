NAntNUnitSample
===============

This is a sample NAnt and NUnit c# solution which demonstrates how to build and test using NAnt and NUnit. NUnit and NAnt are prerequisites along with .Net framework to get thru this.

Important:

1. Fork or download this repository and extract it to your local folder.
2. Install NAnt and NUnit and configure System's Path (environment variable) value to include NAnt bin folder.
3. Open GlobalBuildSettings.xml in SampleSolution.Build and update "local.workspace" property to the path where you extracted your project.
    Ex: D:\Work\SampleWebApp\... is your path, please update it to D:\Work
4. Open command prompt and try running "nant -help". If you get help, then your NAnt is running fine.
5. Then use cd "<path>" to point your cmd to the location where you have sampleSolution.Build contents
    Ex: D:\Work\SampleWebApp\src\SampleSolution.Build\
6. Type "nant" in cmd.

The execution displays the progress and status.

Thanks you!
