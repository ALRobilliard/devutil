# DevUtil

Command line utility written in .NET for generating GUIDs and Passwords

## Installation
1. Install .NET 6 https://dotnet.microsoft.com/en-us/download/dotnet/6.0
2. Clone the devUtil repository and store in a local directory on your machine
3. Run ```dotnet pack``` in the base directory of devUtil
4. Run ```dotnet tool install --global --add-source ./nupkg devutil``` to install devutil as a global CLI command

## Functions:
### generateGuid
Generates a new GUID value, displays it, and copies it to your clipboard

**Usage**
```devutil generateGuid```

**Optional Parameters**
- --lowercase, -l: generates a GUID in lowercase

```devutil generateGuid -l```

### generatePassword
Generates a new password value, displays it, and copies it to your clipboard

**Usage**
```devutil generatePassword```

**Optional Parameters**
- --length, -l: override the password length/number of characters in generated password
- --no-numbers, -nn: exclude numbers from being used in the generated password
- --no-symbols, -ns: exclude symbols from being used in the generated password

``` devutil generatePassword -l 12 -ns```