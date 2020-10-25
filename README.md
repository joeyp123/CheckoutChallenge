# Checkout Challenge

## About
This tool allows a list of products to be loaded from a CSV file, along with their price and any discounts that might apply to them.
A user can then enter products of the those types and the tool will display the total cost, a list of the items entered and details of any discounts which may have been applied.

## Setup
This project targets .Net Framework 4.7.2. 
It can be ran in debug mode from Visual Studio (or any C# compatible IDE) or alternatively it can be compiled and then ran using the .exe in the bin folder.

## Possible future improvements
- A button which clears basket but leaves the loaded SKUs
- The ability to remove individual items
- Let the file reader check whether the CSV has a header or not (currently just skips the first line). 
	- Could make property loading dynamic for any column order (if a header exists)
- Winforms are now available in .Net Core so this could be upgraded.