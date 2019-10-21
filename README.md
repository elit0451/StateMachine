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

The output will be stored in a file in `\bin\Debug` project folder as `log.txt`. You can provide a different path by changing .
