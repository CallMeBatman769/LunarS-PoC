# LunarS-PoC

** What does it do and how does it work? **
LunarS-PoC uses window titles to search for any login or registration site the user is currently in. If a 
window is in the top position that contains words like login or registration it prints it to the console.
Attackers could replace the Console.WriteLine functionality with a full keylogger to capture keystrokes only
when the user is in a login prompt.

** Why not just inject into chrome/the browser or read the masterkey from memory and decrypt all keys? **
This is a good question. All of these methods are faster then the method LunarS-PoC uses, but at what cost?
All of the mentioned methods are far more noisy and will trigger anti-virus products faster. LunarS also works for
every browser the exact same with the exact same code while you need to recode the other methods depending on the browser
(for example for gecko or chrome browser).

# PLEASE REMEMBER THIS IS ONLY A POC AND SHOULD NOT BE USED TO STEAL ACTUAL PASSWORDS!!!