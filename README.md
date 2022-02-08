# Some-Modifications
- Gives negative effects when someone walks in the SCP-173 tantrum
- Lets you edit SCP-096's AHP when it's in rage and the shield recharge rate
- Makes a message appear for SCP-096 when he goes into rage
- Makes a message appear for the SCP-096 when he's calming down
- A message also appears for those who looked at the SCP-096 and gives them the effect of panic
- A message appears that the person is being corroded when stepping on the SCP-173 tantrum
- When 939 bites it gives the bleeding effect or the poisoned effect depending on the type of 939
- Gives a configurable speed boost to SCP-173 when he places the tantrum
- Lets you edit the shield recharge rate of 096's shield when he is enraged
- Lets you edit how much times you can pickup the SCP-330 candy

Effects when you walk on the tantrum:

- Bleeding
- Poisoned

I know that the code is garbage (But i TRIED to do something good)
you have any suggestions of things to add, if you can DM me then on discord: Gal.#3167

(Shout out to Sexiled Contributer and Joker for helping me out)

Configs:

some_modifications:
# If the plugin is enabled
  is_enabled: true
  # How much time 173 stays with the Movement Boost effect after placing the tantrum
  scp173_movement_boost_time: 10
  # how much time a person is poisoned after walking in the SCP-173 tantrum
  poison_time_walking_on_tantrum: 6
  # How much time a person is bleeding after walking in the SCP-173 tantrum
  bleeding_time_walking_on_tantrum: 5
  # How much time someone stays panicking after looking at 096
  panic_time: 5
  # Max AHP of 096 in rage
  max096_a_h_p_in_rage: 1500
  # How much time he gains of rage when someone looks at him
  time_that096_gains_of_rage_when_someone_looks: 2
  # The amount of time that someone stays bleeding when the SCP-93953 bites him (Minimum time for the bleeding to work: 8)
  hitscp93953_bleeding_time: 9
  # The amount of time that someone stays poisoned when the SCP-93989 bites him (Minimum time for the poison to work: 8)
  hitscp93989_poisoned_time: 8
  # The recharge rate of 096's shield when he enters in rage (Base-Game default: 40) Ps: I recommend the default config that i put because increasing it would be too op.
  scp096_shield_recharge_rate: 45
  # The intensity of the 173 speed boost when he places the tantrum
  scp173_speedboost_intensity: 20
  # The amount of candies that someone can pickup before his hands get severed, the way it works is: If you put the value in 0 it will be the default thing, so when someone picks up more than 2 candies his hands will get severed but if you put 1 it will be 3 and so on.
  number_of_candies_you_can_pick: 5
  # If the enraging things of SCP-096 are enabled
  scp096_enrage_things: true
  # If the SCP-173 Tantrum damage things are enabled
  scp173_tantrum_damage_things: true
  # If the SCP-173 Placing Tantrum things are enabled
  scp173_placing_tantrum_things: true
  # If the SCP-939 things are enabled
  scp939_things: true
  # If the Report-PopUp Thing is enabled
  report_pop_up_is_enabled: true
  # If players should get the effects: Poisoned/Bleeding removed when they have used a medkit or a scp500
  should_medkit_remove_effects: true
  # The effect that SCP-93953 should give to the player when he hits the player
  scp93953_on_bite_effect: Bleeding
  # The effect that SCP-93989 should give to the player when he hits the player
  scp93989_on_bite_effect: Poisoned
  
  Translations:
  
  some_modifications:
# The message that appears when 096 is enraged
  angry_message: You are <color=red>ANGRY</color>
  # The message that appears when 096 is calming down
  walking_on_tantrum_message: You are getting <color=black>corroded</color>.
  # The message that appears to someone when the looked at 096
  looked_to096: you are panicking.
  # The message that appears when a SCP-93953 hits the player and the player starts bleeding
  hitscp93953_message: As a result of your injuries you started to bleed.
  # The message that appears when SCP-173 places the tantrum
  placing_tantrum_message: You feel faster...
  # The message that appears when a player joins the server (It appears as a report Pop-Up)
  joined_the_server_message: Welcome to my cool server, enjoy your stay! :D
  # The message that appears to someone when a SCP-93989 bites him
  hitscp93989_message: You are poisoned
