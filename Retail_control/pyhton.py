import pandas as pd
import numpy as np
import os
from sqlalchemy import  *
# # # Input the path to the file that contains all excel files
# # excel_path = input("Input the excel path: ")

# # # Create a complete path to the excel files
# # Employee = "Employee.xlsx"
# # Merchandise = "Merchandise.xlsx"
# # Receipt_item = "Receipt_item.xlsx"
# # Receipt = "Receip.xlsx"
# # Employee_full = os.path.join(excel_path,Employee)
# # Merchandise_full = os.path.join(excel_path,Merchandise)
# # Receipt_item_full = os.path.join(excel_path,Receipt_item)
# # Receipt_full = os.path.join(excel_path,Receipt)


# # # Use pd to read the excel files and return to the Dataframe of pandas
# # Employee_info = pd.read_excel(Employee_full)
# # Merchandise_info = pd.read_excel(Merchandise_full)
# # Receipt_item_info = pd.read_excel(Receipt_item_full)
# # Receipt_info = pd.read_excel(Receipt_full)


import pandas as pd
from sqlalchemy import create_engine

# Replace with your own database connection string
database_connection_string = 'mysql+pymysql://root:Benjaminto&24122003@Macbook_pro.local/retail'

# Create a connection to the database
engine = create_engine(database_connection_string)

# Read the data from the Excel file
excel_file = '/Users/benjamin/Documents/GitHub/Project/Retail_control/excel_file/Employee.xlsx'
df = pd.read_excel(excel_file, engine='openpyxl')

# Insert the data into the SQL database
for index, row in df.iterrows():
    # Assuming the columns in the Excel file match the columns in the SQL table
    insert_query = f"""
    INSERT INTO Employees (Store_ID, Employees_ID, Name, Position, Manager)
    VALUES ('{row['Store ID']}', '{row['Employees ID']}', '{row['Name']}', {row['Position']}, {row['Manager']})
    """
    # engine.execute(insert_query)
    with engine.connect() as conn:
        result = conn.execute(insert_query)