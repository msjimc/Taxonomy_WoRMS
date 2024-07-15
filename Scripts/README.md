# Python script 

Once the annotation is completed, it may be necessary to manually go through the exported files to check that each species is expected to be present in the sample. For example if your samples originate from the Amazon rain forest and one of the sequences is annotated as  Mammuthus primigenius, you can be reasonably sure the sequence is not correctly annotated as there have not been many recorded signing of woolly mammoths in that specific region. Since many eDNA experiments involve two or more different amplicons, such as 18S and COI it can be come time consuming to screen both datasets for aberrantly annotated sequences. Consequently the p_CompareEditedAnnotatedReadCountsToNewReadCountsFile.py script was created to screen an 'edited' file for comments linked to a species name, genius etc and then move it over to a 2nd file that has not been edited. To work the edited comments in the 'donor' file most conform to a specific structure:

### Format of the files 

It is expected that the files are tab-delimited text files, with the first line in each file consisting of the column header names.

### Format of comments in the edited file

The script requires 2 columns in the edited file with the option of an optional 3rd column, each column must have a unique column name. These columns can be located anywhere in the file and their header names/titles can be anything, but most not be duplicated in other header names. The columns are described in the table below:

|Generic name|Description of data in the field|
|-|-|
|Sequence name|This column should contain the name alloted to the entires sequence, it can be anything, but is probably a taxonomic name such as species, genus or family name. This term will be used to link a sequence to the manually created annotation and so must also be present in the file to be annotated|
|Status|This can be any value that is expected to relate to whether the sequence should be retained, ignored or investigated further, i.e "Y", "N", "?". If the field is empty it is set to "NS" for 'Not set'|
|Source|This field contains the source of the data used to determine whether the sequence is retained or not. It could something like a paper, database or website.|

### Runing the script

The script is run form a terminal with a command similar to this:

> python 'p_CompareEditedAnnotatedReadCountsToNewReadCountsFile.py' '18S_annotated_edited.txt' 'Status' 'Source' 'Name' 'COI_annotated_unedited.txt' 'name' 'COI_annotated_transferred.txt'

where:

|Parameter|Description|
|-|-|
|python|Indicates python should be used to process the script|
|p_CompareEditedAnnotatedReadCountsToNewReadCountsFile.py| Script name including path|
|18S_annotated_edited.txt|Name of file with manual annotation|
|Status|Name of column that contains information on whether the sequence should be ignored or not|
|Source|Data describing the source of the data used to determine the status value|
|Name|Column that gives the taxonomic term linked to the sequence|
|COI_annotated_unedited.txt|Name of file with path that is to be annotated|
|Name|The header name of the column that contains the taxonomic term used to link the annotation in the manually edited file to the file to be edited|
|COI_annotated_transferred.txt|The name of the exported file that contains the data from the unedited file to which the manually edited information has been added|

Taxonomic terms may occur multiple times in a file and it's possible that the decision was independently determined using different data sources. In this situation, all data sources will be given separated by a ';' character.

The status data will be appended to the end of each line in the COI_annotated_transferred.txt under the column names of: name, Status and Source. 