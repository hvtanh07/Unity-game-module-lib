# List of created systems that can be reused
* Character System
* Pooling System
* Combat System with hit box
* Grid System

# How to use each of the systems
## Character System
### 1. How to use the Character System
* The character system includes the character.cs file, which controls all other modules attached to the character, even if the component is located in a child object.<br /> 
* To use the character system, attach the character.cs file to the parent object, then attach any necessary components to it or its child to make it communicate with the character component.

### 2. How to scale the Character System
* To add more character modules, simply copy the DemoCharacterSystem.cs content and modify it to your needs.
* Each module must be obsolete and is not allowed to reference other modules. All events and data can be accessed through the character module.
* If using the character system on multiple character types, they will have to share the same stats, events, and state check. So consider using different Character systems for different types of characters.

## Pooling System
### How to use the Pooling System
* The pooling system can create a pool of multiple types of objects. To get a specific type of object, use the object tag
* Simply add an empty object to the scene and attach the ObjectPooling.cs to it.  
