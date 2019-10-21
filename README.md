# State Machine :card_index:
This repository presents an implementation of a **Finite State Automaton** that mimics a actions performed on a running application (system). The automaton is be able hold states :white_square_button: of a running instance.  
</br>

Our application is monitoring :shipit: :mag_right:: 
- if the action is legal according to the present state :construction:;
- if an instance is stuck at a non-final (non-accepting) state :checkered_flag:.

</br>

----

## Log analyser

> **Format** of Log entry is as follows:

<table>
    <tr>
        <td align="center">Level</td>
        <td>
        <table>
                <tr>
                    <td align="center">Information :information_source:</td>
                </tr>
                <tr>
                    <td align="center">Warning :warning:</td>
                </tr>
                <tr>
                    <td align="center">Error :no_entry:</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="center">System</b></td>
        <td align="center">System id</td>
    </tr>
    <tr>
        <td align="center">Instance</b></td>
        <td align="center">Instance id</td>
    </tr>
    <tr>
        <td align="center">Action</b></td>
        <td align="center">Action id</td>
    </tr>
    <tr>
        <td align="center">Timestamp</b></td>
        <td align="center">Time of the event</td>
    </tr>
</table>

</br>

The output will be stored in a file in `\bin\Debug` project folder as `log.txt`. You can provide a different path by changing [ln25](https://github.com/elit0451/StateMachine/blob/ccecddad678e4452d8a636e0be916355f5d447d8/StateMachine/Logger.cs#L25).

</br>

The valid states an application can go through are defined in `stateList.txt` file, having its location in [\bin\Debug](https://github.com/elit0451/StateMachine/blob/ccecddad678e4452d8a636e0be916355f5d447d8/StateMachine/Program.cs#L16) folder
> Example
```
start-login
login-edit
login-list
edit-logout
list-logout
```

</br>

The sequence of actions the application will evaluate can be seen in [Program.cs](https://github.com/elit0451/StateMachine/blob/master/StateMachine/Program.cs):
```C#
Action(automaton, "login");
Action(automaton, "edit");
Action(automaton, "login");
```

</br>

The output written in the `log.txt` file for the case stated above would be as follows:
```
Level - Information
System - bebe5e3f-d8d2-41a6-80db-b15f3fdb604a
Instance - b88f3dec-f7e8-402f-81db-8875906fdb92
Action - login
TimeStamp - 10/8/2019 7:15:40 PM
-------------------------------


Level - Information
System - bebe5e3f-d8d2-41a6-80db-b15f3fdb604a
Instance - b88f3dec-f7e8-402f-81db-8875906fdb92
Action - edit
TimeStamp - 10/8/2019 7:15:40 PM
-------------------------------


Level - Error
System - bebe5e3f-d8d2-41a6-80db-b15f3fdb604a
Instance - b88f3dec-f7e8-402f-81db-8875906fdb92
Action - login
TimeStamp - 10/8/2019 7:15:40 PM
-------------------------------
```

</br>

___
> #### Assignment made by:   
`David Alves 👨🏻‍💻 ` :octocat: [Github](https://github.com/davi7725) <br />
`Elitsa Marinovska 👩🏻‍💻 ` :octocat: [Github](https://github.com/elit0451) <br />
> Attending "Discrete Mathematics" course of Software Development bachelor's degree
