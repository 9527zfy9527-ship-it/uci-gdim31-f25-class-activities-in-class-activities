# in-class-activities
## Devlogs
### W1
In this situation, the cemera will not follow the cat when cat is moving, as at that time they are not a part.

### W2
1.As the range of these color is from 0 to 1.0, so that we should use float like:0.2, 0.6 to control the color better
2.Bounces means the number of the jump, in this case it can not use float to show how many times the ball jumps.
3.In C# we should use ";" to sperate the code.

### w3
#### Activity 1
1. ⁠GetResponse⁠ (Visual Novel)
 Parameters (Input): ⁠int favorability⁠, ⁠bool knowsSecret⁠
 Return Type (Output): ⁠string⁠
 Code Signature: ⁠string GetResponse(int favorability, bool knowsSecret)⁠
2. ⁠SetLightDimness⁠ (Horror Game)
 Parameters (Input): ⁠float sanity⁠
 Return Type (Output): ⁠void⁠
 Code Signature: ⁠void SetLightDimness(float sanity)⁠
3. ⁠DidPlayerHitBeat⁠ (Rhythm Game)
 Parameters (Input): ⁠float keyPressTime⁠
 Return Type (Output): ⁠bool⁠
 Code Signature: ⁠bool DidPlayerHitBeat(float keyPressTime)⁠
#### Activity 2
A class is like a blueprint for a car stereo, defining its overall design and capabilities, while a component is the actual stereo hardware built from that blueprint and installed into a specific car (⁠GameObject⁠). Within this analogy, member variables represent the stereo's properties (such as ⁠maxVolume⁠ or ⁠brand⁠), and methods are the functions the stereo can perform (such as ⁠PlayMusic()⁠ or ⁠SetVolume()⁠).
#### Activity 3
Each bounce increases light intensity or material emission (e.g., ⁠intensity *= 1.2f⁠) without a maximum cap, causing compounding exposure and overbrightness.

### w4
#### problem1 
For this activity, I added Rigidbodies to both the Cat and the SoccerBall because they need to be affected by physics—such as moving, kicking, and bouncing off walls. I added Colliders to all three objects: a Capsule Collider for the Cat, a Sphere Collider for the SoccerBall, and a Box Collider for the Goal. I only checked 'Is Trigger' on the Goal's Box Collider so that the ball can pass through the goal area while still detecting when a goal is scored.
#### problem2
When I first tested the game, the bounce forces for the Cat and the SoccerBall didn't feel quite right. Because the cat is larger and heavier, while the soccer ball is much smaller and lighter, I had to fine-tune their BounceOffWall settings. I adjusted the bounce force so that the soccer ball's reaction was noticeably weaker than the cat's, making their movements against the walls look much more natural.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153
- itch: https://zfy9527.itch.io/gdim-31-11
