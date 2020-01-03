----

#### <a name="fees"></a>Phase System (used in multiple games)
One of the requirements of all the linear games we're building is that every chapter can be skipped & restarted. For this reason I've built a _phase system_ which controls the flow of the game. 
Every chapter (defined by the designer) is programmed as a _phase_. Phases have a Reset method, a Start method and an End method. Every phase implements this abstract phase class. 
* With the ResetPhase method you make sure all objects are set to their initial state needed to start the phase.
* With the StartPhase method you first call ResetPhase after which you can start the implemented sequences a phase runs through.
* At the end of the phase you call the EndPhase method which fires the _event_ OnPhaseCompleted. The PhaseController handles this event, makes sure the next phase starts (if there is one) and cleans up.

![](/images/projects/floor-games/system_phase.png)

I used this phase system for all linear games that I've build which is three in total.

[Back to the top](#top)