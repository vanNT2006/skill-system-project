# Master Skill Effects Table

This document lists the baseline properties and effects of all skill components available in the game, categorized by their skill type (Element, Form, Modifier).

---

## 1. Elements (Elemental Properties & Status Effects)

| Component ID | Element Name | Damage Type | Primary Effect Description | Status Duration |
|---|---|---|---|---|
| `ELEM_FIRE` | Fire | Fire | Applies **Burn** status, dealing $X$ damage per second. Spreads to combustible environmental objects. | 3.0 seconds |
| `ELEM_ICE` | Ice | Frost | Applies **Slow** status, reducing movement speed by 30%. Reaching 3 stacks triggers **Freeze** (stun). | 4.0 seconds |
| `ELEM_WATER` | Water | Physical | Applies **Wet** status. Deals no damage but primes the target for Electric/Freeze reactions. | 5.0 seconds |
| `ELEM_ELECTRIC`| Lightning | Electric | Deals instant shock damage. Chains to nearby **Wet** targets. | Instant |

---

## 2. Forms (Visual Shapes & Trajectories)

| Component ID | Form Name | Default Speed | Shape & Trajectory Description | Range / Size |
|---|---|---|---|---|
| `FORM_PROJECTILE`| Projectile | Fast | Fires a single projectile that travels in a straight line. | Long Range |
| `FORM_AOE` | Area of Effect| Stationary | Spawns a circular field centered on the target or caster. | Medium Radius |

---

## 3. Modifiers (Physical & Behavioral Tweaks)

| Component ID | Modifier Name | Target Parameter | Behavioral Modification Description | Notes |
|---|---|---|---|---|
| `MOD_HOMING` | Homing | Trajectory | Steers the spell's trajectory towards the nearest active enemy target. | Reducess base turn rate for balance. |
| `MOD_BOUNCING` | Bouncing | Collision | Projectile bounces off solid walls and enemies instead of destroying itself. | Max 3 bounces. |
