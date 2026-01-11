/*
 2.Role-Based Access Control (RBAC)
Use Case: Assign and verify user roles and permissions.
OOP Concepts:
● Interface: Role
● Encapsulation: Role mappings hidden inside auth system.
● Abstraction & Polymorphism: Different roles implement different behavior.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// interface
interface IRole
{
    bool CheckPermission(string permission);
}
// subclasses
class Admin : IRole
{
    // admin has all permission
    public bool CheckPermission(string permission)
    {
        return true;
    }
}

class User : IRole
{
    public bool CheckPermission(string permission)
    {   // user has only read permission
        if (permission == "READ") return true;
        else return false;
    }
}

// class handling users and check access
internal class AuthSystem
{
    Dictionary<string, IRole> users = new Dictionary<string, IRole>();

    public void AssignRole(string name, IRole role)
    {
        users[name] = role;
    }

    public bool HasAccess(string name, string permission)
    {
        return users.ContainsKey(name) && users[name].CheckPermission(permission);
    }
}
