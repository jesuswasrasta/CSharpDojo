(http://matteo.vaccari.name/blog/archives/927)[link]

#First step
We want an app that shows a working semaphore, with the three usual lights red, green and amber. The semaphore works with the following cycle:

Initially only the red light is on.
After 60 seconds, the red light goes off, the green light is turned on.
After 30 seconds, the amber light is turned on.
After 10 seconds, both amber and green go off, and red is turned on.
And again and again…
This can be done in Java with a Swing user interface, or in Javascript with an HTML user interface.

Demo: you should show the GUI with the lights turning on and off. You may speed up the tempo just to make the demo less boring :-)

Second step
We must now handle a crossing with four semaphores, like this:

            o
            o (B0)
            o


o                        o
o (A0)                   o (A1)
o                        o

            o
            o (B1)
            o
We have four semaphores A0, A1, B0, B1. A0 and A1 must always show the same lights. B0 and B1 must always show the same lights. B0’s cycle is delayed by 50 seconds with respect to A0. As a consequence, there should NEVER be a green light on all four semaphores! And there should be a safety 10 seconds interval when all four semaphores show red. The following diagram shows what the semaphores should show.

Every letter represents 10 seconds

     time:     ----------->
A0 and A1:  RRRRRRGGGARRRRRRGGGA
B0 and B1:  RGGGARRRRRRGGGARRRRR

R = Red light
G = Green light
A = Green + Amber light
For the instructor
How to test a GUI? (Hint: you don’t; you apply model-view separation and move all of the logic to the model. You should read the “Humble Dialog Box” paper.) There should be a “Semaphore” domain object.

How to test the passing of time? (Hint: the most productive way is to assume that the app will receive a “tick” message every second. This is also an instance of model-view separation; the “tick” message is sent by a clock. This is just the same as if there was a user clicking on a button that advances the simulation by one second.)

How do participants demo the application? Insist on seeing the application work for real. A demo that consists of showing unit tests passing is NOT satisfactory. Try to make developers use both unit tests and manual tests. Insist on concrete, demoable progress.

The goal of the second step is to check that the developers use two (or four) instances of the Semaphore object from the first step, instead of making a big, monolithic “two-way semaphore” that controls all of the lights.