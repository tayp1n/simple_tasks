# simple_tasks

Develop a class "Account for payment". Provide the following fields in the class:
■ pay per day;
■ number of days;
■ penalty for one day delay in payment;
■ number of days delay payment;
■ amount payable without penalty (calculated field);
■ penalty (calculated field);
■ total amount due (calculated field).
In the class, declare a static property of bool type, the value of which affects
the process of formatting objects of this class. If the value of this property is
true, then all fields are serialized and deserialized, if false - calculated
fields are not serialized.
Develop an application in which you want to demonstrate the use
of this class, the results must be written to and read from the file.