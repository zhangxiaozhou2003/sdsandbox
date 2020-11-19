# Dev Doc

## Setup
1. Do everything written in the `README` of this repo until `Demo`.

## Creating new track
1. Load the Unity project `sdsandbox/sdsim` in Unity.
2. From the `Project` menu double click on `Assets/Scenes/test` to open that scene.
3. From the `Project` menu double click on `Assets/Resources/test` to open the path input file.
4. We can create the path with command `S`, `R`, `L`, and `DY` with a number as its argument. `S` stands for go straight. `R` stands for turn right. `L` stands for turn left. `DY` is used to setting up the curvature for turning. An input file as the following is `Go straight for 10 units, and turn right for 5 units with the curvature of 3 units`.
```
S 10
DY 3
R 5s
```
5. Save you modified `Assets/Resources/test` file, go back to the Unity and click the `Play` button, now you should see both your car is spawned and your path is generated.

## Car config (Spawned by server)
### Mass of a car
The sim trade the whole car as a rigid body with 4 wheels. We can set their mass by opening `sdsim/Assets/Prefabs/Donkey.prefab` in a text editor. Modify the arguments after the `m_Mass` command for the rigid body and 4 wheels.

### Length
under construction...

### Style
under construction...

## Car config (Spawned by client)
under construction...

## Train and predict
Specified in the `README` of this repo.

## Multi-client racing
The server support multi-client racing, but the screen would only split into two at most. Once you have your models, we can start racing.

1. Start Unity project sdsim and bring up a scene.
2. Click the `Play` button and Push button `NN Control over Network` in the race panel.
3.  Run the following command.

```
cd sdsandbox/src
python run_pokeman.py --model=YOUR_MODEL1_NAME YOUR_MODEL2_NAME ...
```