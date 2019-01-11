# Steam easy switch
This program determines which steam accounts you have already entered on your computer and allow you to switch from one to another without typing the password and steam guard code.

The program was based on this reddit post: https://www.reddit.com/r/GlobalOffensive/comments/7kvuvc/this_script_will_let_you_easily_switch_between_2/

It reads the loginusers.vdf file and lists the accounts that have already been used to log in to steam. After that it retrieves the profile photos from the "avatarcache" folder and displays it on the screen. When you select the account, the program automatically closes the steam process, changes the registry and reopens the steam.

For the operation of the account switch function never end the session through the steam interface.

![alt text](https://i.imgur.com/Rnu25Eh.png)

In order to change the registry, it is necessary to have administrator privileges. The software only handles the account name, profile name, steam id, and profile photo. No data is collected by software.
