# Unexpected Mutable Variable Behavior in F#

This repository demonstrates a common pitfall when working with mutable variables and functions in F#.  The `swap` function appears to correctly swap the values of two mutable variables, but only within its immediate scope. This is because F# passes mutable variables by reference.

## Bug Description:
The provided `bug.fs` file contains a function `swap` that attempts to swap two mutable variables.  While it works correctly within the function, it fails to modify the original variables passed as arguments outside the function's scope. 

## Solution:
The `bugSolution.fs` file provides a corrected approach using tuples to return the swapped values, which correctly addresses the issue.