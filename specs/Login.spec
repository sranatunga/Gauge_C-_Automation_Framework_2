# Login specification

## Login With Valid Credentials
tags: user, registration, smoke, regression

* Go to login page
* Login as "standard_user" using "secret_sauce"
* Verify title "PRODUCTS"

## Login via table data approach

 |username|password|
 |------|-----------|
 |standard_user|secret_sauce|
 |locked_out_user|secret_sauce|
 |problem_user|secret_sauce|

* Go to login page
* Login as <username> using <password>
* Verify title "PRODUCTS"

## Login via csv driven approach

table: resources/testdata/users.csv

* Go to login page
* Login as <user> using <pass>
* Verify title "PRODUCTS"

