extends CanvasLayer

func _ready():
	$btn_play.connect('pressed', self, 'btn_play')
	$btn_chars_choice.connect('pressed', self, 'btn_chars_choice')
	$btn_options.connect('pressed', self, 'btn_options')
#	$btn_back.connect('pressed', self, 'btn_back')
#	$btn_pause.connect('pressed', self, 'pause_game')

#	$btn_play_touch.connect('pressed', self, 'btn_play')
#	$btn_chars_choice_touch.connect('pressed', self, 'btn_chars_choice')
#	$btn_options_touch.connect('pressed', self, 'btn_options')
#	$btn_back_touch.connect('pressed', self, 'btn_back')
#	$btn_pause_touch.connect('pressed', self, 'pause_game')


func btn_play():
	G.score = 0
	G.hp = 3
	get_tree().change_scene("res://root.tscn")


func btn_chars_choice():
	get_tree().change_scene("res://m_chars_choice.tscn")

func btn_options():
	get_tree().change_scene("res://m_options.tscn")

func btn_back():
	get_tree().change_scene("res://main_menu.tscn")

#func pause_game():
#	get_tree().paused



