#!/usr/bin/python

KEY = "RSAXvpFy2Tq"
DB = "static/db"
REQUIRED_ID = "K4QoqCn4eOX"

def get_id(login, passwd):
	return "".join([ chr(ord(login[i]) ^ ord(passwd[i]) ^ ord(KEY[i])) for i in range(len(KEY)) ])

with open(DB, "rt") as f:
	lines = f.readlines()

for line in lines:
	login, passwd = line.strip().split(":")
	if get_id(login, passwd) == REQUIRED_ID:
		print(line)
