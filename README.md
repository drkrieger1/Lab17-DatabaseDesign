![cf](http://i.imgur.com/7v5ASc8.png) Lab 17 : Travel Packer Pt. 2
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a directory named `lab-#`; + `<your name>` **e.g.** `lab14-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas


## Directions
- Recreate your Travel Packer site from day one. You do not need to include the repository that we worked on in class 16.
- Design a database schema for your Travel Packer website. 
- You should have at least 2 tables (Destination & Supplies). 
- Draw out the different tables and identify the foreign keys, primary keys, and associations between each (1 - *, * - *, etc...)
- Include the Navigation Properties within your diagram 
- use [This](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model) as a reference when creating your data model diagram.
- Make these tables you created be represented as Models in your website.
- Be sure that all the tables you created are represented in both the database and in your model folder

## Things to Note:
- Within your model, Most of the tables should represent models within your code. 
- It is possible to have tables that are not represented through models in your database (i.e. WeatherType, AmusementParkType etc..)
- When creating your table, only connect tables to your model if they seem appropriate. You may need to mamually add other tables to your database if they are just type holders. Another alternative is to use Enums to hold type values. 

## ReadMe
- Your readme should include the following information:
	- How long did it take you to complete this assignment?
	- What did you struggle with? Why? How did you solve?
	- What did you learn during this assignment?
    - What resources did you utilize for this assignment?

## Rubric
- 2pts: Application runs without any errors
- 2pts: At least 3 tables created
- 3pts: Diagram of tables, contains relationships, and key associations
- 2pts: Model, View, and Controller are properly set up/configured
- 1pts: Readme included with answers to questions
