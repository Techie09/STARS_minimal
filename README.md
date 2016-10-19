# STARS_minimal

@Kal challenged me to smallest code base that can complete student app reqs. I'll give two metrics. first being how many lines of IL there are, the second being how many Source Lines of Code there are. my first attempt was 25/49.  @Kal reduced it down to 14/35 using dynamics and optimizing design. I improved input and some output to get a final count of 7/25.

I also took the liberty to use a tool that can be useful in cases, but should be used responsibly. Its called ILRepack. The tool Repacks multiple Aseembly(exe, dll, etc) files into another Assembly. So the app now has Newtonsoft built into the executable. 

To use the App, you will want to open a cmd in the same directory as the executable. then type in "stars" and a studentID, or part of a name. such as "stars 34"
