extends KinematicBody2D

var speed = 250
var rotation_speed = 4

var velocity = Vector2()
var rotation_dir = 0
#var rotation_degrees = 90  # эксперимент

var j_angle = 0
var j_speed = 0



func _physics_process(delta):
	get_input()
	velocity = move_and_slide(velocity)
	rotation += rotation_dir * rotation_speed * delta
	process_input(delta)
	
	#joystick
	j_angle = $joystic.stick_angle
	j_speed = $joystic.stick_speed

	if (j_angle):
		$player.rotate(j_angle)
	#joystick



func get_input():
	rotation_dir = 0
	velocity = Vector2();
	if Input.is_action_pressed("move_right"):
		rotation_dir = 1
#		velocity = Vector2(0, -speed).rotated(rotation) # эксперимент
	if Input.is_action_pressed("move_left"):
		rotation_dir -= 1
#		velocity = Vector2(0, -speed).rotated(rotation) # эксперимент
	if Input.is_action_pressed("move_down"):
		velocity = Vector2(0, speed).rotated(rotation)
	if Input.is_action_pressed("move_up"):
		velocity = Vector2(0, -speed).rotated(rotation)
	velocity = velocity.normalized() * speed



func process_input(_delta):
	if Input.is_action_just_pressed("quit_game"):
		get_tree().quit()




