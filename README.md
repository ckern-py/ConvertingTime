# ConvertingTime 
This is a repo containing a console app I created that will help you convert time. 

## Description
This repo contains a console app I created that will help you convert time. You enter a number into the GUI, 
select the unit that you would like your input to be in, and then select the unit you would like the output 
to be in. When calculating you'll have two options. You can choose Calculate or Advanced Calculate. Calculate 
will return the answer as a decimal of the output unit. Advanced calculate will break down the answer into time 
units so you can see exactly how many hours, minutes, seconds, etc. it will be. 
## Install
Installing this application should be simple. You need to make sure you have NETFramework Version 4.7.2 installed. 
Then you can clone the repo in Visual Studio and open the solution file. 
## Use
To use the project you'll first need to load it up in Visual Studio. After loading you can go ahead and run it. 
Once the project is loaded and running you'll be presented with a GUI, as seen below. 
<br> ![GUIPic](/Images/ConvertingTime_GUI.png) <br>In this GUI you'll be able to enter a number, select the origin units, 
select the units you would like the answer to be converted to, and then select Calculate or Advanced Calculate. Advanced 
Calculate shows the answer formatted into time units, while Calculate just shows the answer as a decimal. 
## Example
Below is an example on the different outputs that the application can do. For this example, we will input _123456789_ as 
the number we want to convert. We will also select Origin Units as Seconds and Destination Units as Years.

When we hit Calculate we see that the number of years is displayed as a decimal<br>
![CalcPic](/Images/ConvertingTime_Calc.png)

When we hit Advanced Calculate we see that the answer is broken down by years, weeks, days, hours, minutes, and seconds. <br>
![AdvCalcPic](/Images/ConvertingTime_AdvCalc.png)

## License
[GNU GPLv3](https://choosealicense.com/licenses/gpl-3.0/)
