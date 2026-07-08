# Interaction Matrix

This document is the SINGLE SOURCE OF TRUTH for all emergent interactions between Elements, Forms, and Modifiers. Do not describe interactions inside individual mechanic files — only link to this document.

## How to Use
- Each pair of components must be described ONCE.
- Format: `[ID_A] + [ID_B] -> [Effect Description] | Balancing Notes`
- When adding a new component, you must add its interactions with ALL compatible existing components.

## Interaction Tables

### Element x Element (Elemental Reactions)
| Pair | Effect Description | Balancing Notes |
|---|---|---|
| `ELEM_FIRE + ELEM_WATER` | **EVAPORATE:** Deals high instant damage, clears both statuses, and spawns a steam cloud that reduces enemy visibility. | Steam cloud size should be limited to avoid lag. |
| `ELEM_WATER + ELEM_ICE` | **FREEZE:** Immobilizes the target completely for 2.0 seconds. | Add diminishing returns if applied repeatedly. |
| `ELEM_FIRE + ELEM_ICE` | **MELT:** Deals 200% damage but immediately removes any active slow/freeze status from the target. | Good for high burst damage combos. |
| `ELEM_WATER + ELEM_ELECTRIC` | **ELECTRIFY:** Spreads electric shock damage over time (DoT) to all wet enemies standing close to each other. | Limit search radius for chain lightning. |

### Element x Form
| Pair | Effect Description | Balancing Notes |
|---|---|---|
| `ELEM_FIRE + FORM_PROJECTILE` | **FIREBALL:** Projectile inflicts Burn status on impact (DoT damage). | Fireball speed is average. |
| `ELEM_ICE + FORM_AOE` | **FROST_ZONE:** Spawns a freezing ground zone that slows all enemies entering it by 50%. | Zone duration should be around 4 seconds. |

### Element x Modifier
| Pair | Effect Description | Balancing Notes |
|---|---|---|

### Form x Modifier
| Pair | Effect Description | Balancing Notes |
|---|---|---|
| `FORM_PROJECTILE + MOD_HOMING` | **HOMING_ARROW:** The projectile automatically steers toward the nearest enemy. | Reduce projectile turn speed to allow dodging. |
| `FORM_PROJECTILE + MOD_BOUNCING` | **BOUNCING_BULLET:** The projectile bounces off walls and enemies up to 3 times. | Reduce damage by 15% on each bounce. |
