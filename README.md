# C# Practice

This repository contains challenges for you undertake to build on your coding and technical ability. We will be checking over your solutions, so please ensure you push to GitHub regularly. 

You may find these exercises challenging but they give you the opportunity to strengthen your growth mindset and commitment to programming and learning in general. You can always come to us if you are having any trouble.

We will be covering C# on the Your Return to Tech course, so it's really important your problem solving skills are fresh. 

If you need reminding of any key C# concepts to solve these challenges we recommend the 'Codecademy: Learn C#' (free) course: https://www.codecademy.com/learn/learn-c-sharp

NOTE: You are not required to purchase any PRO content from CodeAcademy.

Remember to break down problems to help you solve them and that Google is your friend!

### Instructions

To complete these exercises you will need .NET Core installed on your computer.

Follow this link to download and install .NET Core for your laptop:

https://dotnet.microsoft.com/download

Once you've got .NET Core installed you can make a start - before you do please make sure to watch the [getting started video](https://storage.googleapis.com/your-return-to-tech/pre-journey/java_exercises_intro.mp4) as it walks you through instructions for getting started and the first exercise.

### Completing the tasks

Firstly you will need to [fork this GitHub repository](https://docs.github.com/en/free-pro-team@latest/github/getting-started-with-github/fork-a-repo) to your own GitHub profile and then clone your forked repository down to your laptop.

**NOTE: You do NOT have to submit Pull Requests to us.**

Once you have cloned the repository you can ensure any dependencies are restored by running:

    dotnet restore

If you look inside the **TechReturnersExercises** directory you will find a file of functions to implement.

To understand how these functions work, take a look in the corresponding test file where the desired functionality is described.

To run the tests, run

    dotnet test

Work through each test 1 by 1 until you have them all passing. Initially, you'll have a lot of failing tests and a lot of output on the console. To focus on a single test, you can run specific tests such as:
    
    dotnet test --filter Exercise001
    
Or to run a single test within a test file you can run dotnet test --filter FunctionName like so:

    dotnet test --filter CapitalizeWord

# The tasks

You can see the first tasks in [Exercise001.cs](./TechReturnersExercises/Exercise001.cs) and more information in the [docs](./docs)
