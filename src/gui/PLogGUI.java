/********************PLogGUI**********************************
 * Habbo Packet Logger GUI
 * Applet for Habbo packet logger
 * 
 * Author: Ronny Macmaster
 * Date: 3/27/16
 ***************************************************************/
package gui;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.image.BufferedImage;

import jpcap.*;
import java.io.*;

public class PLogGUI{
	/** Globals */
	NetworkInterface[] NETWORK_INTERFACES;
	JpcapCaptor CAP;
	CaptureThread CAPTAIN;
	int INDEX = 0;
	int COUNTER = 0;
	boolean CaptureState = false;

	/** GUI Globals */
	BufferedImage guiIcon;
	JFrame mainWindow = new JFrame("Habbo Packet_Logger v1.0 - ©2016 Ronny Macmaster");
	JTextArea TA_OUTPUT = new JTextArea();
	JScrollPane SP_OUTPUT = new JScrollPane();
	ButtonGroup BG_Filters = new ButtonGroup();
	ButtonGroup BG_Ports = new ButtonGroup();
	JButton B_CAPTURE = new JButton("CAPTURE");
	JButton B_STOP = new JButton("STOP");
	JButton B_SELECT = new JButton("SELECT");
	JButton B_LIST = new JButton("LIST");
	JButton B_FILTER = new JButton("FILTER");
	JButton B_INFO = new JButton("INFO");
	JButton B_SAVE = new JButton("SAVE");
	JButton B_LOAD = new JButton("LOAD");
	JButton B_HELP = new JButton("HELP");
	JButton B_EXIT = new JButton("EXIT");
	JRadioButton RB_FilterEnable = new JRadioButton("Enable");
	JRadioButton RB_FilterDisable = new JRadioButton("Disable");
	JRadioButton RB_Port_Special = new JRadioButton("Special Port");
	JRadioButton RB_Port_HTTP = new JRadioButton("HTTP (80)");
	JRadioButton RB_Port_SSL = new JRadioButton("SSL (443)");
	JRadioButton RB_Port_FTP = new JRadioButton("FTP (21)");
	JRadioButton RB_Port_SSH = new JRadioButton("SSH (22)");
	JRadioButton RB_Port_TelNet = new JRadioButton("TelNet (23)");
	JRadioButton RB_Port_SMTP = new JRadioButton("SMTP (25)");
	JRadioButton RB_Port_POP3 = new JRadioButton("POP3 (110)");
	JRadioButton RB_Port_IMAP = new JRadioButton("IMAP (143)");
	JRadioButton RB_Port_IMAPS = new JRadioButton("IMAPS (993)");
	JRadioButton RB_Port_DNS = new JRadioButton("DNS (53)");
	JRadioButton RB_Port_NetBIOS = new JRadioButton("NetBIOS (139)");
	JRadioButton RB_Port_SAMBA = new JRadioButton("SAMBA (137)");
	JRadioButton RB_Port_AD = new JRadioButton("AD (445)");
	JRadioButton RB_Port_SQL = new JRadioButton("SQL (118)");
	JRadioButton RB_Port_LDAP = new JRadioButton("LDAP (389)");
	JLabel L_Title = new JLabel("Habbo Packet_Logger v1.0 - ©2016 Ronny Macmaster");
	JLabel L_Interface = new JLabel("Interface");
	JLabel L_FilterStatus = new JLabel("Port Filter Status");
	JLabel L_FilterStatusBox = new JLabel("DISABLED (ALL PORTS)");
	JLabel L_Presets = new JLabel("Port Filter Presets");
	JLabel L_SpecialPort = new JLabel("Special Port #");
	JTextField TF_SelectInterface = new JTextField();
	JTextField TF_SpecialPort = new JTextField();

	/** Entry point */
	public static void main(String[] args){
		PLogGUI userGUI = new PLogGUI();
	}

	/** GUI Constructor */
	public PLogGUI(){
		try{
			guiIcon = ImageIO.read(new File("icon.bmp"));
			buildGUI();
			// disableButtons();
		} catch(IOException e){
			System.err.println("Failled to build GUI! exiting...");
		}

	}

	/** BuildGUI() initializes the PLogGUI settings */
	public void buildGUI(){
		// calculate screen size
		Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
		int width = 800;
		int height = 600;
		int s_width = (int)screenSize.getWidth();
		int s_height = (int)screenSize.getHeight();

		// using absolute layout
		mainWindow.setSize(width, height);
		mainWindow.setLocation((s_width - width) / 2, (s_height - height) / 2);
		mainWindow.setIconImage(guiIcon);
		mainWindow.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		mainWindow.getContentPane().setLayout(null);

		// packet text area
		TA_OUTPUT.setEditable(false);
		TA_OUTPUT.setFont(new Font("Monospaced", 0, 12));
		TA_OUTPUT.setForeground(Color.blue);
		TA_OUTPUT.setLineWrap(true);

		// text scroll
		SP_OUTPUT.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
		SP_OUTPUT.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		SP_OUTPUT.setViewportView(TA_OUTPUT);
		SP_OUTPUT.setBounds((width / 60), (height / 24), (width * 19 / 20), (height * 9 / 16));
		mainWindow.getContentPane().add(SP_OUTPUT);

		/**************************************************************************************************
		 * Command_Buttons
		 * 
		 * Control Higher Level Packet Logging Commands
		 **************************************************************************************************/

		// CAPTURE Button
		B_CAPTURE.setBackground(Color.green);
		B_CAPTURE.setForeground(Color.white);
		B_CAPTURE.setBounds((width / 60), (height * 5 / 8), (width * 1 / 8), (height * 1 / 24));
		B_CAPTURE.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_CAPTURE(X);
			}
		});
		mainWindow.getContentPane().add(B_CAPTURE);

		// STOP Button
		B_STOP.setBackground(Color.black);
		B_STOP.setForeground(Color.white);
		B_STOP.setBounds((width * 10 / 60), (height * 5 / 8), (width * 1 / 8), (height * 1 / 24));
		B_STOP.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_STOP(X);
			}
		});
		mainWindow.getContentPane().add(B_STOP);

		// SELECT Button
		B_SELECT.setBackground(Color.black);
		B_SELECT.setForeground(Color.white);
		B_SELECT.setBounds((width / 60), (height * 13 / 16), (width * 1 / 8), (height * 1 / 24));
		B_SELECT.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_SELECT(X);
			}
		});
		mainWindow.getContentPane().add(B_SELECT);

		// LIST Button
		B_LIST.setBackground(Color.black);
		B_LIST.setForeground(Color.white);
		B_LIST.setBounds((width / 60), (height * 14 / 16), (width * 1 / 8), (height * 1 / 24));
		B_LIST.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_LIST(X);
			}
		});
		mainWindow.getContentPane().add(B_LIST);

		// FILTER Button
		B_FILTER.setBackground(Color.black);
		B_FILTER.setForeground(Color.white);
		B_FILTER.setBounds((width * 31 / 60), (height * 27 / 32), (width * 1 / 8), (height * 1 / 24));
		B_FILTER.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_FILTER(X);
			}
		});
		mainWindow.getContentPane().add(B_FILTER);

		// INFO Button
		B_INFO.setBackground(Color.black);
		B_INFO.setForeground(Color.white);
		B_INFO.setBounds((width * 10 / 60), (height * 12 / 16), (width * 1 / 8), (height * 1 / 24));
		B_INFO.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_INFO(X);
			}
		});
		mainWindow.getContentPane().add(B_INFO);

		// SAVE Button
		B_SAVE.setBackground(Color.black);
		B_SAVE.setForeground(Color.white);
		B_SAVE.setBounds((width * 10 / 60), (height * 11 / 16), (width * 1 / 8), (height * 1 / 24));
		B_SAVE.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_SAVE(X);
			}
		});
		mainWindow.getContentPane().add(B_SAVE);

		// LOAD Button
		B_LOAD.setBackground(Color.black);
		B_LOAD.setForeground(Color.white);
		B_LOAD.setBounds((width * 18 / 60), (height * 11 / 16), (width * 1 / 8), (height * 1 / 24));
		B_LOAD.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_LOAD(X);
			}
		});
		mainWindow.getContentPane().add(B_LOAD);

		// HELP Button
		B_HELP.setBackground(Color.black);
		B_HELP.setForeground(Color.white);
		B_HELP.setBounds((width * 18 / 60), (height * 12 / 16), (width * 1 / 8), (height * 1 / 24));
		B_HELP.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_HELP(X);
			}
		});
		mainWindow.getContentPane().add(B_HELP);

		// EXIT Button
		B_EXIT.setBackground(Color.red);
		B_EXIT.setForeground(Color.white);
		B_EXIT.setBounds((width * 18 / 60), (height * 5 / 8), (width * 1 / 8), (height * 1 / 24));
		B_EXIT.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_EXIT(X);
			}
		});
		mainWindow.getContentPane().add(B_EXIT);

		/**************************************************************************************************
		 * Radio_Buttons
		 * 
		 * Control Network Filtering (unique selection)
		 **************************************************************************************************/

		// ENABLE filter
		BG_Filters.add(RB_FilterEnable);
		RB_FilterEnable.setBounds((width * 26 / 60), (height * 12 / 16), (width * 1 / 12),
				(height * 1 / 24));
		RB_FilterEnable.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_RB_FilterEnable(X);
			}
		});
		mainWindow.getContentPane().add(RB_FilterEnable);

		// DISABLE filter
		BG_Filters.add(RB_FilterDisable);
		RB_FilterDisable.setSelected(true);
		RB_FilterDisable.setBounds((width * 31 / 60), (height * 12 / 16), (width * 1 / 10),
				(height * 1 / 24));
		RB_FilterDisable.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_RB_FilterDisable(X);
			}
		});
		mainWindow.getContentPane().add(RB_FilterDisable);

		// Special
		BG_Ports.add(RB_Port_Special);
		RB_Port_Special.setBounds((width * 31 / 60), (height * 51 / 64), (width * 1 / 8),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_Special);

		// HTTP
		BG_Ports.add(RB_Port_HTTP);
		RB_Port_HTTP.setFont(new Font("Serif", 0, 9));
		RB_Port_HTTP.setBounds((width * 39 / 60), (height * 42 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_HTTP);

		// SSL
		BG_Ports.add(RB_Port_SSL);
		RB_Port_SSL.setFont(new Font("Serif", 0, 9));
		RB_Port_SSL.setBounds((width * 39 / 60), (height * 45 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_SSL);

		// FTP
		BG_Ports.add(RB_Port_FTP);
		RB_Port_FTP.setFont(new Font("Serif", 0, 9));
		RB_Port_FTP.setBounds((width * 39 / 60), (height * 48 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_FTP);

		// SSH
		BG_Ports.add(RB_Port_SSH);
		RB_Port_SSH.setFont(new Font("Serif", 0, 9));
		RB_Port_SSH.setBounds((width * 39 / 60), (height * 51 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_SSH);

		// TelNet
		BG_Ports.add(RB_Port_TelNet);
		RB_Port_TelNet.setFont(new Font("Serif", 0, 9));
		RB_Port_TelNet.setBounds((width * 39 / 60), (height * 54 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_TelNet);

		// SMTP
		BG_Ports.add(RB_Port_SMTP);
		RB_Port_SMTP.setFont(new Font("Serif", 0, 9));
		RB_Port_SMTP.setBounds((width * 45 / 60), (height * 42 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_SMTP);

		// POP3
		BG_Ports.add(RB_Port_POP3);
		RB_Port_POP3.setFont(new Font("Serif", 0, 9));
		RB_Port_POP3.setBounds((width * 45 / 60), (height * 45 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_POP3);

		// IMAP
		BG_Ports.add(RB_Port_IMAP);
		RB_Port_IMAP.setFont(new Font("Serif", 0, 9));
		RB_Port_IMAP.setBounds((width * 45 / 60), (height * 48 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_IMAP);

		// IMAPS
		BG_Ports.add(RB_Port_IMAPS);
		RB_Port_IMAPS.setFont(new Font("Serif", 0, 9));
		RB_Port_IMAPS.setBounds((width * 45 / 60), (height * 51 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_IMAPS);

		// DNS
		BG_Ports.add(RB_Port_DNS);
		RB_Port_DNS.setFont(new Font("Serif", 0, 9));
		RB_Port_DNS.setBounds((width * 45 / 60), (height * 54 / 64), (width * 1 / 10),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_DNS);

		// NetBIOS
		BG_Ports.add(RB_Port_NetBIOS);
		RB_Port_NetBIOS.setFont(new Font("Serif", 0, 9));
		RB_Port_NetBIOS.setBounds((width * 51 / 60), (height * 42 / 64), (width * 1 / 9),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_NetBIOS);

		// SAMBA
		BG_Ports.add(RB_Port_SAMBA);
		RB_Port_SAMBA.setFont(new Font("Serif", 0, 9));
		RB_Port_SAMBA.setBounds((width * 51 / 60), (height * 45 / 64), (width * 1 / 9),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_SAMBA);

		// AD
		BG_Ports.add(RB_Port_AD);
		RB_Port_AD.setFont(new Font("Serif", 0, 9));
		RB_Port_AD.setBounds((width * 51 / 60), (height * 48 / 64), (width * 1 / 9),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_AD);

		// SQL
		BG_Ports.add(RB_Port_SQL);
		RB_Port_SQL.setFont(new Font("Serif", 0, 9));
		RB_Port_SQL.setBounds((width * 51 / 60), (height * 51 / 64), (width * 1 / 9),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_SQL);

		// LDAP
		BG_Ports.add(RB_Port_LDAP);
		RB_Port_LDAP.setFont(new Font("Serif", 0, 9));
		RB_Port_LDAP.setBounds((width * 51 / 60), (height * 54 / 64), (width * 1 / 9),
				(height * 1 / 24));
		mainWindow.getContentPane().add(RB_Port_LDAP);

		/**************************************************************************************************
		 * Lables / Titles
		 * 
		 * Labels for various Text fields / application title. etc...
		 **************************************************************************************************/
		
		// Application Title
		L_Title.setForeground(new Color(0x10,0x4A,0x0D)); // army green x104A0D
		L_Title.setFont(new Font("Monospaced", Font.BOLD, 12));
		L_Title.setBounds((width * 1 / 4), (height * 0), (width * 1/2), (height * 1/16));
		mainWindow.add(L_Title);
		
		
		mainWindow.setVisible(true);
	}

	/**************************************************************************************************
	 * Command_Button Event Handlers
	 * 
	 * Perform command-triggered events.
	 **************************************************************************************************/

	public void Action_B_CAPTURE(ActionEvent X){
		TA_OUTPUT.append("capture!\n");
	}

	public void Action_B_STOP(ActionEvent X){
		TA_OUTPUT.append("stop!\n");
	}

	public void Action_B_SELECT(ActionEvent X){
		TA_OUTPUT.append("select!\n");
	}

	public void Action_B_LIST(ActionEvent X){
		TA_OUTPUT.append("list!\n");
	}

	public void Action_B_FILTER(ActionEvent X){
		TA_OUTPUT.append("filter!\n");
	}

	public void Action_B_INFO(ActionEvent X){
		TA_OUTPUT.append("info!\n");
	}

	public void Action_B_SAVE(ActionEvent X){
		TA_OUTPUT.append("save!\n");
	}

	public void Action_B_LOAD(ActionEvent X){
		TA_OUTPUT.append("load!\n");
	}

	public void Action_B_HELP(ActionEvent X){
		TA_OUTPUT.append("help!\n");
	}

	public void Action_B_EXIT(ActionEvent X){
		TA_OUTPUT.append("exit!\n");
	}

	/**************************************************************************************************
	 * Radio_Buttons
	 * 
	 * Control Network Filtering Events
	 **************************************************************************************************/

	public void Action_RB_FilterEnable(ActionEvent X){
		TA_OUTPUT.append("enable!\n");
	}

	public void Action_RB_FilterDisable(ActionEvent X){
		TA_OUTPUT.append("disable!\n");
	}
}
