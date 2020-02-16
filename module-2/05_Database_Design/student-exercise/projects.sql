USE master
GO

DROP DATABASE IF EXISTS ProjectOrganizer

CREATE DATABASE ProjectOrganizer
GO

USE ProjectOrganizer

BEGIN TRANSACTION;

CREATE TABLE departments
(
dept_id int identity (1000, 1),
dept_name varchar (50) NOT NULL,

constraint pk_dept_id primary key(dept_id),
);

CREATE TABLE employees
(
employee_id int identity(10000, 1),
dept_id int NOT NULL,
last_name varchar(50) NOT NULL,
first_name varchar(50) NOT NULL,
job_title varchar(50) NOT NULL,
gender char(1) NOT NULL,
date_birth date NOT NULL,
date_hire date NOT NULL,

constraint pk_employee_id primary key(employee_id),
constraint fk_department_id foreign key(dept_id) references departments(dept_id)
);

CREATE TABLE projects
(
project_id int identity(100, 1),
title varchar(100) NOT NULL,
start_date date NOT NULL,

constraint pk_project_id primary key(project_id)
);

CREATE TABLE employees_projects (
    employee_id integer NOT NULL,
    project_id integer NOT NULL,
    CONSTRAINT pk_employee_project_id PRIMARY KEY (employee_id, project_id)
);

--Insert Departments
INSERT INTO departments (dept_name) VALUES ('FINE ART');
INSERT INTO departments (dept_name) VALUES ('CRAFT');
INSERT INTO departments (dept_name) VALUES ('WRITING');
INSERT INTO departments (dept_name) VALUES ('HORTICULTURE');
INSERT INTO departments (dept_name) VALUES ('DESIGN');
INSERT INTO departments (dept_name) VALUES ('WOODWORKING');

--Insert Projects
INSERT INTO projects (title, start_date) VALUES ('COSTCO ART KITS', '2019-01-04');
INSERT INTO projects (title, start_date) VALUES ('SAM''S CLUB CRAFT KITS', '2018-07-11');
INSERT INTO projects (title, start_date) VALUES ('WORLD MEDIA WRITING CO-EDITION', '2020-02-07');
INSERT INTO projects (title, start_date) VALUES ('QUARTO ART CO-EDITION', '2018-11-21');
INSERT INTO projects (title, start_date) VALUES ('TARGET VALENTINE''S EXCLUSIVE', '2017-03-15');
INSERT INTO projects (title, start_date) VALUES ('WALMART KIDS'' EXCLUSIVE', '2017-05-29');

--Insert Employees
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1000, 'Richards', 'Krista', 'senior editor', 'F', '1970-04-07', '2001-11-19')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1000, 'Lyman', 'Sarah', 'editor', 'F', '1980-06-20', '2018-06-19')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1001, 'Markle', 'Pam', 'senior editor', 'F', '1975-10-08', '1995-02-15')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1001, 'Bonaparte', 'Adrien', 'editor', 'M', '1990-01-01', '2015-09-19')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1002, 'Corlioni', 'Alliya', 'senior editor', 'F', '1986-11-23', '2003-01-20')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1002, 'Brewman', 'Bobbi', 'associate editor', 'M', '1972-02-17', '1997-05-07')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1003, 'LuCheng', 'Marinette', 'senior editor', 'F', '1988-07-18', '2001-08-19')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1003, 'Garibaldi', 'Miguel', 'online editor', 'M', '1955-09-22', '2001-12-01')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1005, 'Robinson', 'William', 'book editor', 'M', '1989-05-05', '2020-1-13')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1005, 'Freeman', 'Jason', 'magazine editor', 'M', '1970-12-24', '2003-04-25')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1004, 'Morris', 'Alex', 'associate designer', 'M', '1985-03-21', '2007-10-02')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1004, 'Clearmonte',' Mandy', 'associate designer', 'F', '1977-04-13', '2005-07-19')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1004, 'Fox', 'Rebecca', 'designer', 'F', '1970-10-21', '2000-02-28')
INSERT INTO employees (dept_id, last_name, first_name, job_title, gender, date_birth, date_hire) VALUES (1004, 'Rodriguez', 'Amarillis', 'senior designer', 'F', '1980-11-03', '1989-12-15')

INSERT INTO employees_projects (employee_id, project_id) VALUES (10000, 100)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10001, 103)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10013, 100)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10011, 103)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10012, 101)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10003, 101)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10002, 105)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10004, 102)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10010, 102)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10006, 101)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10010, 104)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10009, 105)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10005, 104)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10008, 100)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10007, 104)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10012, 105)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10007, 105)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10000, 105)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10001, 100)
INSERT INTO employees_projects (employee_id, project_id) VALUES (10005, 105)

COMMIT;