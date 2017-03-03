//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: Abdelrahman Elbehery
// 
// Create Date:    00:12:46 02/4/2017 
// Design Name: 
// Module Name:    SEVEN_SEG_DISP 
// Project Name: 
// Target Devices: 
// Tool versions: 
// Description: 
//
// Dependencies: 
//
// Revision: 
// Revision 0.01 - File Created
// Additional Comments: 
//
//////////////////////////////////////////////////////////////////////////////////


module SEVEN_SEG_DISP (
  input [7:0] IN,                         //Input byte to show
  input CLK_12MHz,                        //Input clock required for multiplexing the 7-segment disp.
  output reg [7:0] SevenSegment,          //LEDs output [Active Low]
  output reg [2:0] SevenSegmentEnable     //7Seg anode [Active Low]
  );

  //Local signals and modules
  wire [11:0] BCD_o[0:7];
  reg [1:0] sevenSegSelector=0;
  reg [3:0] digit;
  SHIFT_MUX_ADD dut0(12'b0,IN,BCD_o[0]);

  //Generate a chain of ShiftMuxAdd
  genvar i;
  generate
    for(i=1;i<7;i=i+1) begin
      SHIFT_MUX_ADD #(i) dut(BCD_o[i-1],IN,BCD_o[i]);
  end
  endgenerate
  SHIFT_MUX_ADD #(7) dut1(BCD_o[6],IN,BCD_o[7]);

  //Main body goes here
  always @ (posedge CLK_12MHz) begin
    if(sevenSegSelector==0) begin
      SevenSegmentEnable<=3'b110;
      sevenSegSelector<=sevenSegSelector+1;
      digit<=BCD_o[7][3:0];
    end
    else if(sevenSegSelector==1) begin
      SevenSegmentEnable<=3'b101;
      sevenSegSelector<=sevenSegSelector+1;
      digit<=BCD_o[7][7:4];
    end
    else begin
      SevenSegmentEnable<=3'b011;
      sevenSegSelector<=0;
      digit<=BCD_o[7][11:8];
    end
end

always @ (*) begin
  case (digit)
    0: SevenSegment= 8'b11000000; //0
    1: SevenSegment= 8'b11111001; //1
    2: SevenSegment= 8'b10100100; //2
    3: SevenSegment= 8'b10110000; //3
    4: SevenSegment= 8'b10011001; //4
    5: SevenSegment= 8'b10010010; //5
    6: SevenSegment= 8'b10000010; //6
    7: SevenSegment= 8'b11111000; //7
    8: SevenSegment= 8'b10000000; //8
    9: SevenSegment= 8'b10011000; //9
    default: SevenSegment=8'b11111111;
  endcase
end
endmodule // SEVEN_SEG_DRIVER
