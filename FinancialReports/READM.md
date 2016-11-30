Financial Reporting

Table of Contents

Prerequisites
What You Will Be Learning
Requirements
Resources
Prerequisites

DB Browser for SQLite.
Completed the Chinook SQL exercise
Introduction to unit testing
What You Will Be Learning

Interacting with a Database with SQL

You will be using raw SQL statements to query a SQLite database that powers a command line application.

User Input

You will learn how to build a command line application that accepts user input to navigate a terminal-based user interface and then use input to update data in your database.

Test Driven Development (TDD)

For this project, all core logic of the application must have a failing unit test written before any implementation logic is attempted. By following TDD principles, you are ensuring that the program is more solidly designed before work begins.

Refactoring Poorly Designed Code

This project was originally contracted to a developer in a European country through a freelancing web site. The developer was chosen because the rate for the project was the lowest of all people who placed a bid. After realizing how poor the quality of code was, we realized that you get what you pay for. You are now responsible for implementing the requirements with best practices.

Requirements

Unit Testing: Management will not accept a project for which implementation code was written before a unit test. If you have questions about this, you need to speak with your manager.
Author a unit test suite that verifies core logic of application
All data must be stored in a SQL Server database
Create a process to seed the database with the data that currently exists in the DatabaseGenerator class.
Review the menu system described below and refactor the project to use
Main Menu

==========================
BANGAZON FINANCIAL REPORTS
==========================

1. Weekly Report
2. Monthly Report
3. Quarterly Report
4. Customer Revenue Report
5. Product Revenue Report
Weekly Report

Display all sales that occurred in the past 7 days. Order report by product name.

==========================
BANGAZON FINANCIAL REPORTS
==========================

WEEKLY REPORT

Product                       Amount
-------------------------------------
Digital Camera                $52.00
Digital Camera                $52.00
Spatula                       $1.00
Stuffed Animal                $4.00
Monthly Report

Display all sales that occurred in the past 30 days. Order report by product name.

==========================
BANGAZON FINANCIAL REPORTS
==========================

MONTHLY REPORT

Product                       Amount
-------------------------------------
Digital Camera                $52.00
Digital Camera                $52.00
Spatula                       $1.00
Stuffed Animal                $4.00
Quarterly Report

Display all sales that occurred in the past 90 days. Order report by product name.

==========================
BANGAZON FINANCIAL REPORTS
==========================

QUARTERLY REPORT

Product                       Amount
-------------------------------------
Digital Camera                $52.00
Digital Camera                $52.00
Spatula                       $1.00
Stuffed Animal                $4.00
Revenue per Customer

Line item report for each customer that has made a purchase, with total revenue for that customer. 
Order the report by total revenue.

==========================
BANGAZON FINANCIAL REPORTS
==========================

CUSTOMER REVENUE REPORT

Customer                     Revenue
-----------------------------------------
Kaylee Cummings              $4098.12
Michael Mead                 $3551.89
Sarah Story                  $1024.04
Jacob Paine                  $955.33
Glenn Spinner                $49.99
Revenue per Product

Line item report for each product that has been purchased, with total revenue for that product. 
Order the report by total revenue.

==========================
BANGAZON FINANCIAL REPORTS
==========================

PRODUCT REVENUE REPORT

Product                      Revenue
-----------------------------------------
Television                   $14112.47
Bicycle                      $9521.55
Sleeping Bag                 $1024.04
Spatula                      $955.33