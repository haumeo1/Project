'''
Grade Caculator


This program main function is to calculate the final score in both percentage and gpa scale, then show a letter grades base on that
The input is a file path (error will show up if there is anything wrong with file path). In the file there should be 3 elements in row 
which are type of the exam, score and weight for that exam.
If there is anything wrong in the file, the ouput which also print out in a file will show what exactly error the input file has.

Reality, sometimes we don't know for sure a particular point for an exam due to several reasons. In that case, you can leave a charater x 
in the input file for the point of that exam and the program will let you input your intension point (you may input again if the input is not in
the right form of a point).

There is also a warning will pop up if there is any exam that has a different weight from their first type of exam
For example:
Quiz1 has the weight of 10
But Quiz2 has the weight of 5
->Then the warning will pop up but it will do not affect anything to your input file!

'''
# Import library to use it function
from collections import namedtuple
import os


''' 
create a data stucture that store 3 variables together: 
 -type for type of test
 -grade for the score
 -weight of the test
 '''
store = namedtuple('store',['type','grade','weight'])

'''
A global variable which have type of list to store the namedtuple data stucture
'''
arr = []

'''# function to clear the result file contents'''
def clear_file(filename):
    if os.path.exists(filename): # If the file exist clear its content 
        with open(filename,'w') as f:
            f.truncate(0)


'''
Function to print out whether the input is in the wrong form or not
'''
def check_form(bol):

    if bol.lower() == 'wrong form':
        s= "Your file is in the wrong type!\n"
        return s
    
    elif bol.lower() == 'wrong weight':
        s = "The sum of weights is not equal to 100%\n"
        return s
    
    elif bol.lower() == 'wrong grade':
        s = "There is a                                                                                                                                            t least 1 grade that go above 100"
        return s
    

    

def prepare(filename):
    with open(filename,'r') as f:
        
        for line in f: # Run through each of line in the file 
            line = line.strip() # Eliminate space at the beginning and ending of the line 
            if not line: # If the line is empty, move to next line 
                continue
            words = line.split() # seperate 3 different part which is type of the test, grade of the test and weight  
            if len(words)!=3: # If the number of elements is different from 3, end the program  
                
                with open("cps109_a1_output.txt",'a') as f:
                    clear_file('cps109_a1_output.txt')
                    f.write(check_form('wrong form'))
                return False
            # Call the global list
            global arr
            arr.append(store(words[0],words[1],words[2])) # Add the elements into the list in a form of nametuple 
            
        # check whether there are any points that go above 100 
        
        for i in arr:
            if i.grade != 'x':# Surpass any empty grade which has value x
                if float(i.grade) >100: # chech whether the grade go above 100
                    with open("cps109_a1_output.txt",'a') as f:
                        clear_file('cps109_a1_output.txt') # clear the contents 
                        f.write(check_form('wrong grade')) # return wrong grade in the result file
                    return False
            

           

        # check the sum of the weight, the sum of all weights must be equal to 100 
        check_weight = sum(float(t.weight) for t in arr)
        if check_weight != 100: # If the sum of all test weight is different from 100, end the program
            with open("cps109_a1_output.txt",'a') as f:
                clear_file('cps109_a1_output.txt') # clear the contents 
                f.write(check_form('wrong weight')) # the input file is in wrong form - wrong weight form 
            return False
    return True # return True if there is nothing wrong with the input file 

'''
A function to replace any grades that is not availble in the input file
'''
def replace_x(arr):
    for i in range(len(arr)):
        if arr[i].grade == 'x': # if there is no grade in the input file, replace it with your predicted point 
            arr[i] = arr[i]._replace(grade=intention(arr[i].type)) # Call function to replace the grade with your point 
        else:
            # Convert the grade to float only if it's not 'x'
            arr[i] = arr[i]._replace(grade=float(arr[i].grade))
    return arr

'''
A function to take input as your predicted points
'''
def intention(name):
    while True:
        try:
            print('Input your intention point for ',name,': ')
            a = input()
            if float(a) <=100: # If the number input is lower or equal to 100 then it is in correct form
                return float(a)
            else: # If the number of input go above 100, ask the user to try again
                print("Your input points is higher than 100, please try again!")
                continue
        except ValueError:# If the input is not a number
            print("Invalid! Pleae input a number!")

'''
A function to warn you if there is any test that have the same type but have different weight 
'''  
def warning(arr):
    names_seen = {} # a dictionary to store every type exist in the file 
    wrong = [] # a list to store all test that have the same type but have different weight 
    
    for i in range(len(arr)):
        
        if arr[i].type[:-1] in names_seen and arr[i].weight != names_seen[arr[i].type[:-1]]:
            wrong.append(arr[i].type) # if the grade of the test different from its first type of test 
        if arr[i].type[:-1] not in names_seen:
            names_seen[arr[i].type[:-1]] = arr[i].weight # append to the dictionary the type of the test
    return wrong

'''
A function to calculate the final grade 
'''

def calculate(i):
    global arr # call the global arr 
    if i == len(arr):
        return 0
    return (float(arr[i].grade)*(float(arr[i].weight)/100))+calculate(i+1) # calculate the final percentage point using recursive 

'''
A function to transform the grade from percentage scale to gpa scale
'''
def gpa(result):
    # A list with each element is a tuple combine the range of the gpa and the gpa
    ranges = [(59, 0), (66, 1), (69, 1.3), (72, 1.7), (76, 2), (79, 2.3), (82, 2.7), (86, 3), (89, 3.3), (92, 3.7)]
    
    for cutoff, gpa_value in ranges:
        if result <= cutoff: # If the point is in the range of that gpa, return the gpa 
            return gpa_value
    return 4 # If none of the above is satisfy, return the highest gpa which above 92% 

'''
A function to determine the final character grade
'''
    
def character_grade(result, gpa):
    # match the grade with the gpa
    grade_mapping = {
        0: "F",
        1: "D",
        1.3: "D+",
        1.7: "C-",
        2: "C",
        2.3: "C+",
        2.7: "B-",
        3: "B",
        3.3: "B+",
        3.7: "A-",
    }
    # special cases for grade A and grade A+
    if result > 3.7:
        if 92 < gpa < 97:
            return "A"
        elif gpa >= 97:
            return "A+"
    
    return grade_mapping.get(result, "Invalid Grade")




'''
main function
The output is the file named result.txt
'''

def caculate_grade(file):
    # Anounce the format of the input file
    print('''               Start caculate your points !
              
Remember, the file must have 3 variable for each of the line and each of them is seperated by a space.
              
The first one is for the type of the test.
              
The second one is for the grade of the test.
              
Final is for the weight of the test.
          
Grade is on percentage scale
              
If you have a test that do not have grade yet type x instead !
              
                            *******''')   
    global arr
    if prepare(file):
    #  warning function
        wrong = warning(arr)
        if not wrong:
            # replace any x
            arr = replace_x(arr)
            # Caculate

            result = calculate(0)

            # gpa
            gpa_result = gpa(result)

            # character_grade
            grade = character_grade(gpa_result,result)

            
            with open("cps109_a1_output.txt",'a') as f:
                clear_file('cps109_a1_output.txt')
                f.write(f"Your percentage score: {result}\n")
                f.write(f"Your gpa result: {gpa_result}\n")
                f.write(f"Your grade: {grade}\n")
            print("All of your grade have been calculated into cps109_a1_output.txt file!")   
        else:
            for i in range(len(wrong)):
                if i>1:
                    if wrong[i][:-1] != wrong[i-1][:-1]:
                        print(f"Warning: Test '{wrong[i]}' has different weights from your first {wrong[i][:-1]}1!")
                else:
                    print(f"Warning: Test '{wrong[i]}' has different weights from your first {wrong[i][:-1]}1!")
                # Caculate the percentage point
            arr = replace_x(arr)

            result = calculate(0)

            # Determine the gpa
            gpa_result = gpa(result)

            # Determine the character_grade
            grade = character_grade(gpa_result,result)
            # Put all of the result in the output file
            with open("cps109_a1_output.txt",'a') as f:
                clear_file('cps109_a1_output.txt')
                f.write(f"Your percentage score: {result}\n")
                f.write(f"Your gpa result: {gpa_result}\n")
                f.write(f"Your grade: {grade}\n")
            print("All of your grade have been calculated into cps109_a1_output.txt file!")
    # If there is anything wrong with the input file
    else:
        # Announcement for the user
        print("There something wrong with your input file which detector error has been show in the result file!")

'''
Main program 
'''


# Input the file path
try:
    file = input("Input the file path: ")
    # If there is no file to be found
    if not os.path.exists(file):
        print("File not found! Please input a valid file path!")
except:
    # If the input is not in a correct file path form
    print("Please input the correct form of a path!")
# Calling the main function to start the program
caculate_grade(file)









