import pandas as pd
import numpy as np
import os
from sqlalchemy import  *
# Input the path to the file that contains all excel files
excel_path = input("Input the excel path: ")

# Create a complete path to the excel files
Employee = "Employee.xlsx"
Merchandise = "Merchandise.xlsx"
Receipt_item = "Receipt_item.xlsx"
Receipt = "Receip.xlsx"
Employee_full = os.path.join(excel_path,Employee)
Merchandise_full = os.path.join(excel_path,Merchandise)
Receipt_item_full = os.path.join(excel_path,Receipt_item)
Receipt_full = os.path.join(excel_path,Receipt)


# Use pd to read the excel files and return to the Dataframe of pandas
Employee_info = pd.read_excel(Employee_full)
Merchandise_info = pd.read_excel(Merchandise_full)
Receipt_item_info = pd.read_excel(Receipt_item_full)
Receipt_info = pd.read_excel(Receipt_full)

# Create sql file to insert info in each excel sheets into their table in sql
# create a class that contain function to create sql file


