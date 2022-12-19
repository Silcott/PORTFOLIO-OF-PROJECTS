# (ERD) Entity Relationship Diagram
[Click HERE to see my ERD!](https://github.com/Silcott/ISTA_Project/blob/master/DELIVERABLES/Entity_Relationship_Diagram/ISTA_Project_ERD-Silcott-30JUL2020.pdf)

<img align="Center" height="480px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/Cover.svg" alt="html" style="vertical-align:top; margin:4px"> 

# Ticket Recording Application – "Trackin!T".

<img align="Center" height="480px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/ERD/ISTA_Project_ERD-Silcott-30JUL2020-stroke-and-fill.svg" alt="html" style="vertical-align:top; margin:4px"> 

## (ERDs) help you understand relationships between entities within a system, such as customers, products, or order IDs.

### TOPICS DISCUSSED
1. What is conceptual database design: 
##### The purpose of the conceptual design phase is to build a conceptual model based upon the previously identified requirements, but closer to the final physical model. A commonly-used conceptual model is called an entity-relationship model
2. What is an entity: 
##### Entities are basically people, places, or things you want to keep information about.
3. What is a weak entity: 
##### A weak entity is an entity that cannot be uniquely identified by its attributes alone; therefore, it must use a foreign key in conjunction with its attributes to create a primary key. The foreign key is typically a primary key of an entity it is related to.
4. What is an entity attribute: 
##### An attribute describes the property of an entity. An attribute is represented as Oval in an ER diagram. 
###### There are four types of entity attributes:
 - Key attribute
 - Composite attribute
 - Multivalued attribute
 - Derived attribute
5. What is a relationship: 
##### A relationship is represented by diamond shape in ER diagram, it shows the relationship among entities. There are four types of relationships:
6. What is a relationship type
##### One to One Relationship: When a single instance of an entity is associated with a single instance of another entity then it is called one to one relationship. For example, a person has only one passport and a passport is given to one person.
##### One to Many Relationship: When a single instance of an entity is associated with more than one instances of another entity then it is called one to many relationship. For example – a customer can place many orders but a order cannot be placed by many customers.
##### Many to One Relationship: When more than one instances of an entity is associated with a single instance of another entity then it is called many to one relationship. For example – many students can study in a single college but a student cannot study in many colleges at the same time.
##### Many to Many Relationship: When more than one instances of an entity is associated with more than one instances of another entity then it is called many to many relationship. For example, a can be assigned to many projects and a project can be assigned to many students.
7. What is a relationship degree
##### A relationship degree indicates the number of entities or participants associated with a relationship. A unary relationship exists when an association is maintained within a single entity. A binary relationship exists when two entities are associated. A ternary relationship exists when three entities are associated. Although higher degrees exist, they are rare and are not specifically named. (For example, an association of four entities is described simply as a four-degree relationship.)
8. What is a relationship attribute
##### Relationship: The association among entities is called a relationship. For example, an employee works_at a department, a student enrolls in a course. Here, Works_at and Enrolls are called relationships.
##### Relationship Set: A set of relationships of similar type is called a relationship set. Like entities, a relationship too can have attributes. These attributes are called descriptive attributes.
9. What is a candidate key
##### Candidate key is a single attribute or a set of attributes that uniquely identify tuples or record in a database. There can be more than one candidate key for a table among which minimum candidate key can be selected as primary key.
10. What is a super key
##### Super key is a single key or a group of multiple keys that can uniquely identify tuples in a table. Super Key can contain multiple attributes that might not be able to independently identify tuples in a table, but when grouped with certain keys, they can identify tuples uniquely.