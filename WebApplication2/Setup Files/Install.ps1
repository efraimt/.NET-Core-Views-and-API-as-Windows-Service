# In order to install the web service run this
# We will have to add a c parameter that will make the service run automatically (not manually) 
sc.exe create "MabaServiceTrial" binpath="C:\Users\offic\source\repos\WebApplication2\WebApplication2\bin\Release\net7.0\publish\WebApplication2.exe"
#sc MabaServiceTrial stop
#sc MabaServiceTrial start