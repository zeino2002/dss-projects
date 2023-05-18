from flask import Flask,render_template,url_for,request
import pickle

app = Flask(__name__,template_folder="Templates")

model = pickle.load(open("logistic_model.pkl","rb"))
ssc = pickle.load(open("standard_scaler.pkl","rb"))


@app.route('/')
def home():
	return render_template('INput.html')


@app.route('/predict',methods=['POST'])
def predict():
	if request.method == 'POST':
		male = int(request.form["Male"])
		age = int(request.form["age"])
		eductaion = float(request.form["education"])
		current = int(request.form["current"])
		cigs = float(request.form["cigs"])
		pb = float(request.form['bp'])
		st = int(request.form['st'])
		hyb = int(request.form["Hyb"])
		dia = int(request.form["d"])
		tot = float(request.form["tot"])
		sys = float(request.form["sys"])
		diaBp = float(request.form["diaBp"])
		bmi = float(request.form["bmi"])
		hr = float(request.form["hr"])
		glucose = float(request.form["glucose"])
		
		data = [male,age,eductaion,current,cigs,pb,st,hyb,dia,tot,sys,diaBp,bmi,hr,glucose]
		data = ssc.transform([data])
		answer = model.predict(data)
		label = None
		if answer[0] ==0:
			label="No Heart Risk"
		else:
			label="There might be a heart risk in 10 y , stay healthy"
	return render_template("output.html",prediction = label)

    




if __name__ == '__main__':
	app.run(debug=True)

# male = request.get["Male"]
	# age = request.get["age"]
	# eductaion = request.get["education"]
	# current = request.get["current"]
	# cigs = request.get["cigs"]
	# pb = request.get['bp']
	# st = request.get['st']
	# dia = request.get["d"]
	# tot = request.get["tot"]
	# sys = request.get["sys"]
	# diaBp = request.get["diaBp"]
	# bmi = request.get["bmi"]
	# hr = request.get["hr"]