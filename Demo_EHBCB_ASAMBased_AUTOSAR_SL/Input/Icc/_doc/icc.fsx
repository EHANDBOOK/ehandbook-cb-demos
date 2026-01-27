<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN" "fsx_v1_1_0.ml.dtd">
<!--FS2FSX Converter Version 1.0 -->
<MSRSW>
	<CATEGORY>FSX</CATEGORY>
	<ADMIN-DATA>
		<LANGUAGE>de</LANGUAGE>
		<USED-LANGUAGES>
			<L-10 L="DE" />
		</USED-LANGUAGES>
	</ADMIN-DATA>
	<SW-SYSTEMS>
		<SW-SYSTEM>
			<SHORT-NAME>MEDC17</SHORT-NAME>
			<LONG-NAME>
				<L-4 L="EN">EDC/ME(D)17</L-4>
			</LONG-NAME>
			<SW-COMPONENT-SPEC>
				<SW-COMPONENTS>
					<SW-FEATURE>
						<SHORT-NAME>Inter Cooler Calculation</SHORT-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Icc Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>InterCoolerControl.Main</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Steuerung des Ladeluftkühlers</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Steuerung des Ladeluftkühlers</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									Der Ladeluftkühler hat die Aufgabe die Luft nach dem
									Verdichten durch den
									Turbolader abzukühlen. Je kälter die Luft,
									desto höher ist die Luftdichte. Dadurch
									wird eine höhere
									Luftfüllung im Brennraum erreicht. Außerdem wird die
									Klopfneigung des Motors reduziert.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Steuerung des Ladeluftkühlers sorgt dafür, dass ab einer
									bestimmten
									Ansaugtemperatur der Lüfter angeschaltet wird. Die
									Temperatur wird mit dem
									Saugrohrtemperatursensor (in K)
									gemessen. Die Einschalttemperatur wird im
									Parameter
									<TT TYPE="PRM">ICC_atManiOn</TT>
									und die Ausschalttemperatur im Parameter
									<TT TYPE="PRM">ICC_atManiOff</TT>
									vorgegeben. Durch Vorgabe einer höheren Einschalttemperatur
									als
									die Ausschalttemperatur entsteht eine Hysterese, so dass der
									Lüfter nicht zu
									oft ein- und ausgeschaltet wird. Die Variable
									<TT TYPE="VARIABLE">ICC_flgInterCooler</TT>
									aktiviert den
									Ladeluftkühler.
								</L-1>
							</P>

						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
