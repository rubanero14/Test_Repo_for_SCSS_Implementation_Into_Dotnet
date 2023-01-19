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
* Once done, go to ```Extensions``` on the VSC navigation bar, and click ```Manage Extensions```
* On the left sidebar, click ```Online``` tab and search for 'SASS Web Compiler' on the search box on the top right of the window
* Choose the Web Compiler package made by Mads Kristensen, download it, and restart the whole VSC for the installation to be completed
* Upon closing VSC, you will be prompted to ```Modify``` the package, just click it and continue installing
* Once done, open back the project, go to folder named Content again, right-click on the scss file you had created, choose ```Web Compiler``` and click ```compile-file```, you cal also do with shortcut key binding using ```Shift + Alt + Q```
* Now you can run the program to check to see if the SCSS codes applied to the Views, or in this case, the Home Page
* Note: Every time we change the code in the main scss file, we need to re-compile the file again using method as above

___________________________________________________________________________________________________________________________

## Sources: 
* [SASS Web Compiler](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler)
* [Dharanz](https://www.youtube.com/watch?v=fdshEHHnetM) => for ASP.NET Web Application (.NET Framework) projects
* [Mark Drake](https://www.youtube.com/watch?v=A8AWdj8apcU) => for ASP.NET Core Web App projects 
