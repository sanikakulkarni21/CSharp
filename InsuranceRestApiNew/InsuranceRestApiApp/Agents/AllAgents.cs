using MaxNewYorkInsurance.Models;

namespace MaxNewYorkInsurance.Agents;

public delegate void AccountAgent(Policy policy);

public delegate void PremiumAgent(Premium premium);