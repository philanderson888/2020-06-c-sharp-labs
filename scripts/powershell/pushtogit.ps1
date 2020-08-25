function global:pushtogit{
    git add . 
    git commit -m $args[0]
    git push
}
# args short for 'arguments' which are strings passed in with command
pushtogit $args[0]

