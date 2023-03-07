# Test_Repo_for_SCSS_Implementation_Into_Dotnet
Test Repo for SCSS Implementation Into Dotnet using Web Compiler package

_____________________________________________________________________________________________________

## Implementation of SASS into Visual Studio [any-version] for .Net MVC, Web Forms or any other FE related projects

## For MVC .Net project
* Create a simple .NET MVC project, once done, go to folder Views > Home > Index.cshtml and open it
* Clear all the contents except for the @Viewbag.Title code above
* Now create a custom markup like simple "Hello World" nested inside of ```H1``` tag
* Now go to folder named Content and add a new stylesheet file like ```test-scss.scss```, and populate your SCSS code in it
* Once done, go to folder App_Start and open BundleConfig.cs file
* In it, look for ```bundles``` method registering css files, now include your newly created SCSS file into the config with .css not .scss extension, example as below;
```
namespace Test_Repo_for_SCSS_Implementation_Into_Dotnet
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/test-scss.css")); // <= Including scss's compiled version css file to be registered here in BundleConfig file
        }
    }
}
```
* Once done, go to ```Extensions``` on the VS IDE navigation bar, and click ```Manage Extensions```, example as below figure;

![image](https://user-images.githubusercontent.com/85555894/213429167-053d9dcc-c685-4cf8-b8eb-5966e6904953.png)
* On the left sidebar, click ```Online``` tab and search for 'SASS Web Compiler' on the search box on the top right of the window, example as figure below;

![image](https://user-images.githubusercontent.com/85555894/213429518-f36f35c8-eb73-46c8-bb84-422b753fd306.png)
* Choose the Web Compiler package made by Mads Kristensen, download it, and restart the whole VS IDE for the installation to be completed
* Upon closing VS IDE, you will be prompted to ```Modify``` the package, just click it and continue installing
* Once done, open back the project, go to folder named Content again, right-click on the scss file you had created, choose ```Web Compiler``` and click ```compile-file```, you can also do with shortcut key binding using ```Shift + Alt + Q```, example as figure below;

![image](https://user-images.githubusercontent.com/85555894/213430088-5622a93e-412c-4dbe-b9cc-da5dde9e6f8d.png)

* Now you can run the program to check to see if the SCSS codes applied to the Views, or in this case, the Home Page
* Note: Every time we change the code in the main scss file, you not only can re-compile manually, but also can auto-compile on save

___________________________________________________________________________________________________________________________

## Sources: 
* [SASS Web Compiler](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler)
* [Dharanz](https://www.youtube.com/watch?v=fdshEHHnetM) => for ASP.NET Web Application (.NET Framework) projects
* [Mark Drake](https://www.youtube.com/watch?v=A8AWdj8apcU) => for ASP.NET Core Web App projects 
