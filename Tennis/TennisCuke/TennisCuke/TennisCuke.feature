#Feature: TennisCuke
#	AS A Tennis Umpire
#	I WANT a portable digital scoreboard
#	SO THAT I can keep track of a game
#	AND allow others to see the game status
#
#
#@mytag
#Scenario: Player Scores first point
#	Given I have a game and the Score is ‘0‘– ‘0’ 
#	When Player ‘1’ scores
#	Then the score should show as 'Player 1 15 - 0 Player 2‘
#
#
#Scenario: Player Two wins Game
#	Given I have a game and the Score is ‘15‘– ‘40’ 
#	When Player ‘2’ scores
#	Then the score should show as 'Player 1 15 - 55 Player 2‘
#
#Scenario: Mat Scores a point
#	Given I have a game between 'Mat' and 'Claire' And I have a game and the Score is '15' – '40' 
#	When Player ‘1’ scores
#	Then the score should show as 'Mat' '30' - '40' 'Claire'