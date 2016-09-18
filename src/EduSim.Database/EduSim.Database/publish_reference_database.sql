use edusim;

/* Drop database */
source /Scripts/delete_application_database;

/* create and populate reference tables */
source /Scripts/create_reference_tables.sql;
source /Scripts/populate_reference_data.sql;



