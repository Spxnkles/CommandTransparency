# CommandTransparency
A plugin that announces commands executed by your staff, so the community knows if any abuse is happening.

Permissions and commands are at the bottom.

# Features
- Make commands transparent by announcing any command executed!
- Ability to add ignored commands, which will be ignored and not transparent.
- Ability to toggle plugin, in case you're doing something private.

# Showcase
When someone executes a command, and they have the permission their command will become transparent. (Transparent means it will get announced to all players.)

![image](https://user-images.githubusercontent.com/108006275/175763418-4e96ce66-c1ba-424a-83ab-e4811252d752.png)

You can preset ignored commands in the config file. You can put as many as you want, all you gotta do is copy the <string>Command</string> and paste it under the previous one. You can put as many as you want.

![image](https://user-images.githubusercontent.com/108006275/175763492-7669a5ea-ad41-41db-80d1-04bb831c405a.png)

If a command is ignored it won't be announced. In this case /vanish is ignored. However, /god is not, so it gets announced.

![image](https://user-images.githubusercontent.com/108006275/175763527-7f992d04-dfde-4522-bbd7-4bea73fdc2ca.png)

Lastly, you can toggle the command transparency. The plugin won't announce it's been disabled, but it will still say the that you executed /TCT or /ToggleCT. (The red message can be seen by everyone, yellow can only be seen by command executer.

![image](https://user-images.githubusercontent.com/108006275/175763563-dfe0aa2f-cc69-41ef-9070-6c54eb75afe2.png)

Plugin does not announce anything until it's toggled back on.

![image](https://user-images.githubusercontent.com/108006275/175763572-2858ae19-18e7-4255-a7dd-cd153b00bb5a.png)

If you don't want the plugin to make the /TCT command transprarent, add it to ignored. <string>/TCT</string>

![image](https://user-images.githubusercontent.com/108006275/175763576-cb7b83fa-c337-4b4c-80f0-fece0140a380.png)


# Commands
<table>
  <tr>
    <td>Command</td>
    <td>Description</td>
  </tr>
  <tr>
    <td>/ToggleCT</td>
    <td>Toggles command transparency, stopping the announcing of executed commands.
  </tr>
  <tr>
    <td>/TCT</td>
    <td>A shortcut for the command above.</td>
  </tr>
</table>

# Permisisons
<table>
  <tr>
    <td>Permission</td>
    <td>Description</td>
  </tr>
  <tr>
    <td>CommandTransparency.ToggleCT</td>
    <td>Allows users to toggle command transparency using the 2 commands.</td>
  </tr>
  <tr>
  <td>CommandTransparency.TransparentCommands</td>
  <td>Anyone with this permission will have their commands transparent. Unless the plugin is toggled or the command is ignored.</td>
  </tr>
  <table>
Note: Blue hammers automatically have the CommandTransparency.TransparentCommands permission.
