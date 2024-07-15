import sys, platform


slash = "/"
if platform.system() == "Windows":
    slash = "\\"

inFileName = sys.argv[1]
fieldName = sys.argv[2]
sourceName = sys.argv[3]
speciesName = sys.argv[4]
fieldName = fieldName.lower()
sourceName = sourceName.lower()
speciesName = speciesName.lower()
inUneditedFileName = sys.argv[5]
UneditedNameField = sys.argv[6]
outFileName = sys.argv[7]

inFile = open(inFileName,"r")

line = inFile.readline()
items = line.split("\t")

sourceIndex = -1
fieldIndex = -1
speciesIndex = -1
index = -1

maxIndex = -1
for item in items:
    index += 1
    if item.lower() == fieldName:
        fieldIndex = index
        maxIndex = index
    elif item.lower() == sourceName:
        sourceIndex = index
        maxIndex = index
    elif item.lower() == speciesName:
        speciesIndex = index;
        maxIndex = index


if sourceIndex == -1 and fieldIndex == -1 and speciesIndex == -1:
    print("Couldn't find the source, species or field index value: stopping")
    exit
elif sourceIndex == -1 and fieldIndex > -1 and speciesIndex >-1:
    print("Couldn't find the source index value, but carrying on")    
elif fieldIndex == -1:
    print("Couldn't find the field index value: stopping")
elif speciesIndex == -1:
    print("Couldn't find the species index value: stopping")
else:
    print("Found all columns")

names = {}

for line in inFile:
    items = line.split("\t")
    if len(items) > maxIndex:
        status = items[fieldIndex].strip()
        if status == "":
            status = "NS"

        speciesLatinName = items[speciesIndex].strip()
        if speciesLatinName == "":
            speciesLatinName == "NS"

        if sourceIndex > -1:
            sourceAnnotation = items[sourceIndex].strip()
            if sourceAnnotation == "":
                sourceAnnotation = "NS"
        else:
            sourceAnnotation = "NS"

        if speciesLatinName == "Alveolata":
            speciesLatinName = speciesLatinName

        if speciesLatinName != "NS":
            key = speciesLatinName.lower()
            value = status + "\t" + sourceAnnotation
            isIn = key in names.keys()
            if isIn == False:
                names[key] = value
            else:
                oldValue = names[key]
                startName = oldValue[0:2]
                if startName == "NS" and status != "NS":
                    names[key] = value
                elif sourceAnnotation != "NS":
                    isIn = (sourceAnnotation) in oldValue
                    if isIn == False:
                        names[key] = oldValue + ";" + sourceAnnotation
                    
print("Linked " + str(len(names)) + " names to a source")
inFile.close()

unedited = open(inUneditedFileName,"r")

line = unedited.readline()
items = line.split("\t")

maxIndex = -1
fieldIndex = -1
index = -1
for item in items:
    index += 1
    if item.lower() == UneditedNameField:
        fieldIndex = index
 
if fieldIndex > -1:
    print("Found name column in unedited file")
else:
    print("Didn't find name column in unedited file: Stopping")
    exit

out = open(outFileName, "w")
out.write(line.rstrip() + "\tname\tStatus\tSource\n")

for line in unedited:
    items = line.split("\t")
    if len(items) > fieldIndex:
        key = items[fieldIndex].strip().lower()
        isIn = key in names.keys()
        if isIn == True:
            out.write(line.strip() + "\t" + items[fieldIndex] + "\t" + names[key] + "\n")
        else:
            out.write(line.strip() + "\t" + items[fieldIndex] +  "\tNS\tNS\n")

out.close()
out.close()   

